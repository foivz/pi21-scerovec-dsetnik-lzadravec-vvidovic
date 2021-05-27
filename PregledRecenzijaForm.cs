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
    public partial class PregledRecenzijaForm : Form
    {
        Korisnik _korisnik;
        public PregledRecenzijaForm(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void PregledRecenzijaForm_Load(object sender, EventArgs e)
        {
            PrikaziRecenzijeKnjiznice();
        }

        private void btnRecenzijeKnjiznice_Click(object sender, EventArgs e)
        {
            PrikaziRecenzijeKnjiznice();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecenzijeZaposlenika_Click(object sender, EventArgs e)
        {
            PrikaziRecenzijeSvihZaposlenika();
        }
        private void PrikaziRecenzijeKnjiznice()
        {
            dgvRecenzije.DataSource = RecenzijaKnjižnice.DohvatiSveRecenzijeKnjiznice(_korisnik.KnjiznicaID);
            dgvRecenzije.Columns["KnjižnicaID"].Visible = false;
            dgvRecenzije.Columns["KorisnikID"].Visible = false;
        }

        private void PrikaziRecenzijeSvihZaposlenika()
        {
            dgvRecenzije.DataSource = RecenzijaZaposlenika.DohvatiSveRecenzijeZaposlenikaKnjiznice(_korisnik.KnjiznicaID);
            dgvRecenzije.Columns["ZaposlenikID"].Visible = false;
            dgvRecenzije.Columns["KorisnikID"].Visible = false;
        }
    }
}
