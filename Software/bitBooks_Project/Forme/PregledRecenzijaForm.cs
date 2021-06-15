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
    public partial class PregledRecenzijaForm : Form
    {
        Korisnik _korisnik;
        Korisnik odabraniZaposlenik;
        UnosRecenzijeKnjižniceForm unosRecenzijeKnjizniceForm;
        UnosRecenzijeZaposlenikaForm unosRecenzijeZaposlenikaForm;
        public PregledRecenzijaForm(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void PregledRecenzijaForm_Load(object sender, EventArgs e)
        {
            PrikaziRecenzijeKnjiznice();
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            cmbZaposlenik.DataSource = Korisnik.DohvatiZaposlenikeKnjižnice(_korisnik.KnjiznicaID);
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
            dgvRecenzije.Columns["ImeKnjižnice"].HeaderText = "Ime knjižnice";
            dgvRecenzije.Columns["KorisnickoIme"].HeaderText = "Korisničko ime";
            dgvRecenzije.Columns["TekstRecenzije"].HeaderText = "Tekst recenzije";
            dgvRecenzije.Columns["DatumUnosa"].HeaderText = "Datum unosa";
            dgvRecenzije.Columns["RecenzijaID"].Visible = false;
            dgvRecenzije.Columns["KnjižnicaID"].Visible = false;
            dgvRecenzije.Columns["KorisnikID"].Visible = false;
        }

        private void PrikaziRecenzijeSvihZaposlenika()
        {
            dgvRecenzije.DataSource = RecenzijaZaposlenika.DohvatiSveRecenzijeZaposlenikaKnjiznice(_korisnik.KnjiznicaID);
            ZaposleniciDGV();
        }

        private void ZaposleniciDGV()
        {
            dgvRecenzije.Columns["ImeZaposlenika"].HeaderText = "Ime zaposlenika";
            dgvRecenzije.Columns["ImeZaposlenika"].DisplayIndex = 0;
            dgvRecenzije.Columns["PrezimeZaposlenika"].DisplayIndex = 1;
            dgvRecenzije.Columns["PrezimeZaposlenika"].HeaderText = "Prezime zaposlenika";
            dgvRecenzije.Columns["KorisnickoIme"].HeaderText = "Korisničko ime";
            dgvRecenzije.Columns["TekstRecenzije"].HeaderText = "Tekst recenzije";
            dgvRecenzije.Columns["DatumUnosa"].HeaderText = "Datum unosa";
            dgvRecenzije.Columns["RecenzijaID"].Visible = false;
            dgvRecenzije.Columns["ZaposlenikID"].Visible = false;
            dgvRecenzije.Columns["KorisnikID"].Visible = false;
        }

        private void btnUnosRecenzijeZaKnjiznicu_Click(object sender, EventArgs e)
        {
            unosRecenzijeKnjizniceForm = new UnosRecenzijeKnjižniceForm(_korisnik);
            unosRecenzijeKnjizniceForm.ShowDialog();
            PrikaziRecenzijeKnjiznice();
        }

        private void btnUnosRecenzijeZaZaposlenika_Click(object sender, EventArgs e)
        {
            unosRecenzijeZaposlenikaForm = new UnosRecenzijeZaposlenikaForm(_korisnik);
            unosRecenzijeZaposlenikaForm.ShowDialog();
            PrikaziRecenzijeSvihZaposlenika();
        }

        private void btnOdredeniZaposlenik_Click(object sender, EventArgs e)
        {
            DohvatiZaposlenika();
            PrikaziRecenzijeOdredenogZaposlenika();
        }

        private void DohvatiZaposlenika() 
        {
            odabraniZaposlenik = Korisnik.DohvatiKorisnikaPoID((cmbZaposlenik.SelectedItem as Korisnik).KorisnikID);
        }

        private void PrikaziRecenzijeOdredenogZaposlenika() 
        {
            dgvRecenzije.DataSource = RecenzijaZaposlenika.DohvatiRecenzijeOdredenogZaposlenika(odabraniZaposlenik.KnjiznicaID, odabraniZaposlenik.KorisnikID);
            ZaposleniciDGV();
        }
    }
}
