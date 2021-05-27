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
    public partial class PregledClanovaForm : Form
    {
        int? knjiznicaID;
        public PregledClanovaForm(int? knjiznica_ID)
        {
            InitializeComponent();
            knjiznicaID = knjiznica_ID;
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziSveKorisnikeKnjiznice();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilitrirajKorisnike();
        }

        private void FilitrirajKorisnike()
        {
            if (txtIme.Text == "" && txtPrezime.Text == "")
            {
                PrikaziSveKorisnikeKnjiznice();
            }

            else if (txtIme.Text == "" && txtPrezime.Text != "")
            {
                dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikaPoPrezimenu(txtPrezime.Text, knjiznicaID);
            }

            else if (txtIme.Text != "" && txtPrezime.Text == "")
            {
                dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikaPoImenu(txtIme.Text, knjiznicaID);
            }

            else
            {
                dgvKorisnici.DataSource = Korisnik.DohvatiPoImenuIPrezimenu(txtIme.Text, txtPrezime.Text, knjiznicaID);
            }
        }

        private void PrikaziSveKorisnikeKnjiznice()
        {
            dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikeKnjižnice(knjiznicaID);
            dgvKorisnici.Columns["TipID"].Visible = false;
            dgvKorisnici.Columns["KnjiznicaID"].Visible = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
