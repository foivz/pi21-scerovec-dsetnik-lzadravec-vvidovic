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
    public partial class UnosRecenzijeKnjižniceForm : Form
    {
        Korisnik _korisnik;
        RecenzijaKnjižnice novaRecenzija;
        bool recenzijaPostoji;
        public UnosRecenzijeKnjižniceForm(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void UnosRecenzijeKnjižniceForm_Load(object sender, EventArgs e)
        {
            DohvatiRecenziju();
            PostaviComboBoxSource();
            OnemogućiPromjene();

            if (novaRecenzija != null)
            {
                PopuniPoljaAkoRecenzijaPostoji();
                recenzijaPostoji = true;
            }
            else
            {
                PopuniPoljaAkoRecenzijaNEPostoji();
                recenzijaPostoji = false;
            }

        }
        private void btnUredi_Click(object sender, EventArgs e)
        {
            OmogućiPromjene();
        }

        private void PostaviComboBoxSource()
        {
            cmbOcjena.DataSource = RecenzijaKnjižnice.listaOcjena;
        }

        private void DohvatiRecenziju()
        {
            novaRecenzija = RecenzijaKnjižnice.DohvatiKorisnikoveRecenzijeKnjiznice(_korisnik.KorisnikID);          
        }

        private void OnemogućiPromjene() 
        {
            txtKnjiznica.Enabled = false;
            txtDatum.Enabled = false;
            txtKomentar.Enabled = false;
            cmbOcjena.Enabled = false;
        }

        private void OmogućiPromjene()
        {
            txtKomentar.Enabled = true;
            cmbOcjena.Enabled = true;
        }

        private void PopuniPoljaAkoRecenzijaPostoji()
        {
            
                txtDatum.Text = novaRecenzija.DatumUnosa.ToString();
                txtKnjiznica.Text = novaRecenzija.ImeKnjižnice;
                txtKomentar.Text = novaRecenzija.TekstRecenzije;
                cmbOcjena.SelectedIndex = novaRecenzija.Ocjena-1;
                
        }

        private void PopuniPoljaAkoRecenzijaNEPostoji() 
        {
                txtKnjiznica.Text = _korisnik.ImeKnjiznice;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (recenzijaPostoji)
            {
                novaRecenzija.AžurirajRecenziju(txtKomentar.Text, cmbOcjena.SelectedIndex + 1, _korisnik.KorisnikID);
            }
            else 
            {
                novaRecenzija = new RecenzijaKnjižnice();
                novaRecenzija.NovaRecenzija(txtKomentar.Text, cmbOcjena.SelectedIndex+1, _korisnik);
            }
            DohvatiRecenziju();
            PopuniPoljaAkoRecenzijaPostoji();
            OnemogućiPromjene();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
