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

namespace bitBooks_Project.Forme
{
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                if (Korisnik.ProvjeriLozinku(txtUsername.Text, txtPassword.Text))
                {
                    Korisnik _korisnik = new Korisnik();
                    _korisnik = Korisnik.DohvatiKorisnikaPoKorisnickomImenu(txtUsername.Text);
                    Sesija.Korisnik = _korisnik;
                    bitBooksMainForm forma = new bitBooksMainForm();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogrešno unesena lozinka. Molimo Vas pokušajte ponovno.");
                }
            } catch
            {
                MessageBox.Show("Pogrešno uneseni podaci. Molimo Vas pokušajte ponovno.");
            }
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
