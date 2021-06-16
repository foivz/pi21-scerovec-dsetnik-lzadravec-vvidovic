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
    public partial class PregledKnjigaForm : Form
    {
        MailMessage poruka;
        SmtpClient smtp;

        public PregledKnjigaForm()
        {
            InitializeComponent();
        }

        private void PregledKnjigaForm_Load(object sender, EventArgs e)
        {
            dgvKnjige.DataSource = Knjiga.DohvatiNedostupneKnjige();
            dgvKnjigPosudbe.DataSource = Knjiga.DohvatiKnjige();

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if(dgvKnjige.CurrentRow != null)
            {
                Knjiga knjiga = dgvKnjige.CurrentRow.DataBoundItem as Knjiga;
                RezervacijaForm rezervacija = new RezervacijaForm(knjiga);
                rezervacija.ShowDialog();
            }
            
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (dgvKnjigPosudbe.CurrentRow != null)
            {
                Knjiga knjiga = dgvKnjigPosudbe.CurrentRow.DataBoundItem as Knjiga;
                PosudbaForm pos = new PosudbaForm(knjiga);
                if(chkboxDostava.Checked == true){
                    PošaljiEmail(knjiga);
                }
                
                pos.ShowDialog();
            }
        }

        private void PošaljiEmail(Knjiga knjiga)
        {
            try
            {
                poruka = new MailMessage();

                poruka.IsBodyHtml = true;

                poruka.To.Add(new MailAddress("bitbooks.zaposlenik@gmail.com"));

                poruka.Subject = "bitBooks Naručena nova dostava";

                poruka.From = new MailAddress("PIbitBooks@gmail.com");

                poruka.Body = "Poštovani,<br> "  +
                               "Sljedeću knjigu: " + knjiga.Ime + "<br>" +
                               "Potrebno je poslati na sljedeću adresu: " + Sesija.Korisnik.Adresa + "<br>" +
                               "Namijenjena je korisniku: " + Sesija.Korisnik.Ime + Sesija.Korisnik.Prezime + "<br>" +
                               "bitBooks";

                smtp = new SmtpClient();

                smtp.Port = 587;

                smtp.EnableSsl = true;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential("PIbitBooks@gmail.com", "bitBooksPI");

                smtp.Host = "smtp.gmail.com";

                smtp.EnableSsl = true;

                smtp.Send(poruka);


            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("InnerException is: {0}", ex.InnerException);

            }
        }

    }
}
