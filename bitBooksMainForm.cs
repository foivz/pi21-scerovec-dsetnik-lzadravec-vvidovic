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
        PregledClanovaForm pregledClanovaForm;
        PregledRecenzijaForm pregledRecenzijaForm;
        Korisnik _korisnik;
        public bitBooksMainForm()
        {
            InitializeComponent();
        }

        private void bitBooksMainForm_Load(object sender, EventArgs e)
        {
            dgvUseri.DataSource = Korisnik.DohvatiSveKorisnike();
        }

        private void btnPregledClanova_Click(object sender, EventArgs e)
        {
                if(_korisnik.DohvatiTipKorisnika(_korisnik) == "Zaposlenik") 
                {
                    pregledClanovaForm = new PregledClanovaForm(_korisnik.KnjiznicaID);
                    pregledClanovaForm.ShowDialog();
                }    
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            pregledRecenzijaForm = new PregledRecenzijaForm(_korisnik);
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

            txtStatus.Text = _korisnik.DohvatiTipKorisnika(_korisnik);
        }
    }
}
