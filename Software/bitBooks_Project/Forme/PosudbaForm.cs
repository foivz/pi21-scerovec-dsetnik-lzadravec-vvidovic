using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitBooks_Project.Forme
{
    public partial class PosudbaForm : Form
    {
        
        Knjiga _unesenaKnjiga = new Knjiga();
        public PosudbaForm(Knjiga knjiga)
        {
            _unesenaKnjiga = knjiga;
            InitializeComponent();
        }

        private void PosudbaForm_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = _unesenaKnjiga.Ime;
            txtISBN.Text = _unesenaKnjiga.ISBN;
            txtNapisana.Text = _unesenaKnjiga.GodinaPisanja.ToString();
            string fileName = _unesenaKnjiga.ISBN;
            var slika = Properties.Resources.ResourceManager.GetObject(fileName, Properties.Resources.Culture) as Image;
            pictureBox1.Image = slika;
            pictureBox1.Refresh();
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (Korisnik.DohvatiBrojPosudbi(Sesija.Korisnik.KorisnikID) < 3)
            {

                List<Izdanje> izdanje = new List<Izdanje>();
                using (var context = new Entities_db1())
                {
                    var query = from p in context.Publishings
                                where p.ISBN == _unesenaKnjiga.ISBN
                                select new Izdanje
                                {
                                    IzdanjeID = p.PublishingID,
                                    OdjelID = p.DepartmentID,
                                    ISBN = p.ISBN,
                                    IzdavacID = p.PublisherID,
                                    BrojPosudenih = p.NumLoaned,
                                    BrojDostupnih = p.NumAvailable,
                                    GodinaIzdavanja = p.ReleaseYear
                                };
                    izdanje = query.ToList();

                    Loan posudba = new Loan();
                    if (izdanje[0] != null) {
                        posudba.PublishingID = izdanje[0].IzdanjeID;
                        posudba.UserID = Sesija.Korisnik.KorisnikID;
                        posudba.LoanStatus = "Posudena";
                        posudba.DueDate = DateTime.Today.AddDays(30);
                        context.Loans.Add(posudba);
                        context.SaveChanges();
                        SendEmail();
                        Obavijest.GeneriranjeObavijestiPosudbe(Sesija.Korisnik.KorisnikID, _unesenaKnjiga.Ime);
                        MessageBox.Show("Uspješno posuđeno izdanje.");
                        Close();
                    }                  
                }               
            }
            else
            {
                MessageBox.Show("Imate vec maksimalan broj posudbi");
                Close();
            }
        }

        protected void SendEmail()
        {
            try
            {
                MailMessage poruka;
                SmtpClient smtp;
                poruka = new MailMessage();
                poruka.IsBodyHtml = true;
                poruka.To.Add(new MailAddress(Sesija.Korisnik.Email));
                poruka.Subject = "bitBooks rezervacija knjige";
                poruka.From = new MailAddress("PIbitBooks@gmail.com");
                poruka.Body = "Poštovani," + "<br>" +
                               "Uspješno ste posudili knjigu " + _unesenaKnjiga.Ime + "." + "<br>";


                smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("PIbitBooks@gmail.com", "bitBooksPI");
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Send(poruka);
                smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("InnerException is: {0}", ex.InnerException);
            }
        }


        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Email sending cancelled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Email sent sucessfully!");
            }
        }
    }
}
