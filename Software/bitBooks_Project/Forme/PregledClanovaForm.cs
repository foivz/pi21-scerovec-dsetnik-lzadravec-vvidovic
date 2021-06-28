using bitBooks_Project.Dorian_Iznimke;
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
    public partial class PregledClanovaForm : Form
    {
        Korisnik _odabraniKorisnik;
        PregledClanova_PosudbeIRezervacijeForm pregledClanova_PosudbeIRezervacije;
        UnosKorisnikaForm unosKorisnikaForm;
        AžuriranjeKorisnikaForm ažuriranjeKorisnikaForm;

        public PregledClanovaForm()
        {
            InitializeComponent();
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            PrikaziSveKorisnikeKnjiznice();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilitrirajKorisnike();
        }

        private void DohvatiKorisnika()
        {
            if (dgvKorisnici.CurrentRow != null)
            {
                _odabraniKorisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            }
            
        }

        private void FilitrirajKorisnike()
        {
            if (Sesija.Korisnik.TipID == 1)
            {
                if (txtIme.Text == "" && txtPrezime.Text == "")
                {
                    PrikaziSveKorisnikeKnjiznice();
                }

                else if (txtIme.Text == "" && txtPrezime.Text != "")
                {
                    dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikaPoPrezimenuSA(txtPrezime.Text);
                    FiltrirajDGV();
                }

                else if (txtIme.Text != "" && txtPrezime.Text == "")
                {
                    dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikaPoImenuSA(txtIme.Text);
                    FiltrirajDGV();
                }

                else
                {
                    dgvKorisnici.DataSource = Korisnik.DohvatiPoImenuIPrezimenuSA(txtIme.Text, txtPrezime.Text);
                    FiltrirajDGV();
                }
            }
            else
            {
                if (txtIme.Text == "" && txtPrezime.Text == "")
                {
                    PrikaziSveKorisnikeKnjiznice();
                }

                else if (txtIme.Text == "" && txtPrezime.Text != "")
                {
                    dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikaPoPrezimenu(txtPrezime.Text, Sesija.Korisnik.KnjiznicaID);
                    FiltrirajDGV();
                }

                else if (txtIme.Text != "" && txtPrezime.Text == "")
                {
                    dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikaPoImenu(txtIme.Text, Sesija.Korisnik.KnjiznicaID);
                    FiltrirajDGV();
                }

                else
                {
                    dgvKorisnici.DataSource = Korisnik.DohvatiPoImenuIPrezimenu(txtIme.Text, txtPrezime.Text, Sesija.Korisnik.KnjiznicaID);
                    FiltrirajDGV();
                }
            }
            
        }

        private void PrikaziSveKorisnikeKnjiznice()
        {
            if (Sesija.Korisnik.TipID == 1)
            {
                dgvKorisnici.DataSource = Korisnik.DohvatiSveKorisnike(Sesija.Korisnik.KorisnikID);
            }
            else
            {
                dgvKorisnici.DataSource = Korisnik.DohvatiKorisnikeKnjižnice(Sesija.Korisnik.KnjiznicaID);
            }    
            FiltrirajDGV();
        }

        private void FiltrirajDGV()
        {
            dgvKorisnici.Columns["KorisnickoIme"].HeaderText = "Korisničko ime";
            dgvKorisnici.Columns["KorisnickoIme"].DisplayIndex = 0;
            dgvKorisnici.Columns["ImeTipa"].HeaderText = "Tip korisnika";
            dgvKorisnici.Columns["KorisnickoIme"].DisplayIndex = 1;
            dgvKorisnici.Columns["KorisnikID"].Visible = false;
            dgvKorisnici.Columns["TipID"].Visible = false;
            dgvKorisnici.Columns["KnjiznicaID"].Visible = false;
            dgvKorisnici.Columns["Lozinka"].Visible = false;
            dgvKorisnici.Columns["ImeKnjiznice"].Visible = false;
            dgvKorisnici.Columns["AktivacijskiKod"].Visible = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPregledaj_Click(object sender, EventArgs e)
        {
            DohvatiKorisnika();
            pregledClanova_PosudbeIRezervacije = new PregledClanova_PosudbeIRezervacijeForm(_odabraniKorisnik);
            pregledClanova_PosudbeIRezervacije.ShowDialog();
        }

        private void PregledClanovaForm_Load(object sender, EventArgs e)
        {
            PrikaziSveKorisnikeKnjiznice();
            btnObrisi.Visible = false;
            if (Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik) == "Super admin" || Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik) == "Admin")
            {
                btnObrisi.Visible = true;
            }
            
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            DohvatiKorisnika();
            try
            {
                _odabraniKorisnik.ObrisiKorisnika();
            }
            catch (AdminException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            
            PrikaziSveKorisnikeKnjiznice();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            unosKorisnikaForm = new UnosKorisnikaForm();
            unosKorisnikaForm.ShowDialog();
            PrikaziSveKorisnikeKnjiznice();

        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            DohvatiKorisnika();
            if(_odabraniKorisnik != null)
            {
                ažuriranjeKorisnikaForm = new AžuriranjeKorisnikaForm(_odabraniKorisnik);
                ažuriranjeKorisnikaForm.ShowDialog();
                PrikaziSveKorisnikeKnjiznice();
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika.");
            }
           
        }
    }
}
