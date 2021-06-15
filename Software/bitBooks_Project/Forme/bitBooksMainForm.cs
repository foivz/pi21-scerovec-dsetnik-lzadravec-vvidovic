using bitBooks_Project.Forme;
using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitBooks_Project
{
    public partial class bitBooksMainForm : Form
    {
        PrijavaForm prijava;
        RegistracijaForm registracija;
        PregledClanovaForm pregledClanovaForm;
        PregledRecenzijaForm pregledRecenzijaForm;
        Korisnik _korisnik;
        ObavijestiForm obavijesti;
        LiveChatForm liveChatForm;
        PregledKnjigaForm pregledKnjigaForm;
        NovostiForm novostiForm;
        public bitBooksMainForm()
        {
            InitializeComponent();
        }

        private void bitBooksMainForm_Load(object sender, EventArgs e)
        {
            dgvUseri.DataSource = Korisnik.DohvatiSveKorisnike();
            groupBox3.Visible = false;
            
        }

        private void btnPregledClanova_Click(object sender, EventArgs e)
        {
                if(Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik) == "Zaposlenik") 
                {
                    pregledClanovaForm = new PregledClanovaForm();
                    pregledClanovaForm.ShowDialog();
                }    
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            pregledRecenzijaForm = new PregledRecenzijaForm();
            pregledRecenzijaForm.ShowDialog();
        }

        private void btnProvjera_Click(object sender, EventArgs e)
        {
            foreach (Korisnik item in Korisnik.DohvatiSveKorisnike())
            {
                if (item.KorisnickoIme == txtUser.Text && item.Lozinka == txtPw.Text)
                {
                    _korisnik = item;
                    break;
                }
            }
            if (_korisnik != null) 
            {
                txtStatus.Text = _korisnik.DohvatiTipKorisnika(_korisnik);
                groupBox3.Visible = true;
            }  
           
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void prijava_button_Click(object sender, EventArgs e)
        {
            prijava = new PrijavaForm();
            prijava.ShowDialog();
        }

        private void registracija_button_Click(object sender, EventArgs e)
        {
            registracija = new RegistracijaForm();
            registracija.ShowDialog();
        }

        private void obavijesti_button_Click(object sender, EventArgs e)
        {
            obavijesti = new ObavijestiForm();
            obavijesti.ShowDialog();
        }

        private void btnLiveChat_Click(object sender, EventArgs e)
        {
            liveChatForm = new LiveChatForm();
            liveChatForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pregledKnjigaForm = new PregledKnjigaForm();
            pregledKnjigaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novostiForm = new NovostiForm();
            novostiForm.ShowDialog();
        }
    }
}
