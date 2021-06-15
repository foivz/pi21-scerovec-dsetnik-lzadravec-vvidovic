using bitBooks_Project.Dorian_Iznimke;
using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitBooks_Project.Forme
{
    public partial class NovostiForm : Form
    {
        bool btn1;
        bool btn2;
        bool btn3;
        Novost odabranaNovost;
        List<Novost> novosti = new List<Novost>();
        NovostiUnos novostiUnosForm;

        public NovostiForm()
        {
            InitializeComponent();
        }

        private void NovostiForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGUI();
            }
            catch (UnosNovostiException ex)
            {

                MessageBox.Show(ex.Poruka);
                Close();
            }
            
            
        }

        private void RefreshGUI()
        {
            //if(Sesija.TipKorisnika == "Korisnik")
            if (false)
            {
                btnUredi1.Visible = false;
                btnUredi2.Visible = false;
                btnUredi3.Visible = false;
                btnSpremi.Visible = false;
                btnNovo.Visible = false;
            }

            btnSpremi.Enabled = false;
            novosti = NapraviListuNovosti();

            //ako ima bar 3 novosti
            if (novosti.Count > 3 || novosti.Count == 3)
            {
                txtNovost1.Text = novosti[0].Ime;
                txtNovost2.Text = novosti[1].Ime;
                txtNovost3.Text = novosti[2].Ime;
                txtOpis1.Text = novosti[0].Opis;
                txtOpis2.Text = novosti[1].Opis;
                txtOpis3.Text = novosti[2].Opis;
            }

            //ako su samo 2 novosti
            else if (novosti.Count == 2)
            {
                txtNovost1.Text = novosti[0].Ime;
                txtNovost2.Text = novosti[1].Ime;
                txtOpis1.Text = novosti[0].Opis;
                txtOpis2.Text = novosti[1].Opis;
                btnUredi3.Visible = false;
                txtNovost3.Visible = false;
                txtOpis3.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
            }

            //ako je samo jedna novost
            else if (novosti.Count == 1)
            {
                txtNovost1.Text = novosti[0].Ime;
                txtOpis1.Text = novosti[0].Opis;
                btnUredi2.Visible = false;
                txtNovost2.Visible = false;
                txtOpis2.Visible = false;
                btnUredi3.Visible = false;
                txtNovost3.Visible = false;
                txtOpis3.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
            }

            //ako nema novosti
            else
            {
                btnUredi1.Visible = false;
                txtNovost1.Visible = false;
                txtOpis1.Visible = false;
                btnUredi2.Visible = false;
                txtNovost2.Visible = false;
                txtOpis2.Visible = false;
                btnUredi3.Visible = false;
                txtNovost3.Visible = false;
                txtOpis3.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label1.Visible = false;
            }
            
            OnemogućiPromjene();
        }

        private void OnemogućiPromjene()
        {
            txtNovost1.Enabled = false;
            txtNovost2.Enabled = false;
            txtNovost3.Enabled = false;
            txtOpis1.Enabled = false;
            txtOpis2.Enabled = false;
            txtOpis3.Enabled = false;
        }

        private void OmogućiPromjene()
        {
            if (btn1)
            {
                txtNovost1.Enabled = true;
                txtOpis1.Enabled = true;
            }

            if (btn2)
            {
                txtNovost2.Enabled = true;
                txtOpis2.Enabled = true;     
            }

            if (btn3)
            {
                txtNovost3.Enabled = true;
                txtOpis3.Enabled = true;
            }
            
        }

        private static List<Novost> NapraviListuNovosti()
        {
            //tu ocemo iz session vaditi id knjiznice
            return Novost.DohvatiNovostiKnjiznice(1);
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn1)
                {
                    odabranaNovost.AžurirajNovost(txtNovost1.Text, txtOpis1.Text, odabranaNovost.NovostId);
                }

                if (btn2)
                {
                    odabranaNovost.AžurirajNovost(txtNovost2.Text, txtOpis2.Text, odabranaNovost.NovostId);
                }

                if (btn3)
                {
                    odabranaNovost.AžurirajNovost(txtNovost3.Text, txtOpis3.Text, odabranaNovost.NovostId);
                }

            }
            catch (UnosNovostiException ex)
            {

                MessageBox.Show(ex.Poruka);
            }
            

            RefreshGUI();

        }

        private void BtnUredi1_Click(object sender, EventArgs e)
        {
            OnemogućiPromjene();
            btn1 = true;
            btn2 = false;
            btn3 = false;
            OmogućiPromjene();
            odabranaNovost = novosti[0];
            btnSpremi.Enabled = true;
        }

        private void BtnUredi2_Click(object sender, EventArgs e)
        {
            OnemogućiPromjene();
            btn2 = true;
            btn1 = false;
            btn3 = false;
            OmogućiPromjene();
            odabranaNovost = novosti[1];
            btnSpremi.Enabled = true;
        }

        private void BtnUredi3_Click(object sender, EventArgs e)
        {
            OnemogućiPromjene();
            btn3 = true;
            btn1 = false;
            btn2 = false;
            OmogućiPromjene();
            odabranaNovost = novosti[2];
            btnSpremi.Enabled = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novostiUnosForm = new NovostiUnos();
            novostiUnosForm.ShowDialog();
            RefreshGUI();
        }
    }
}
