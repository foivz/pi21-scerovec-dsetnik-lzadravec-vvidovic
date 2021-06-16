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
        PregledClanovaForm pregledClanovaForm;
        PregledRecenzijaForm pregledRecenzijaForm;      
        ObavijestiForm obavijesti;
        LiveChatForm liveChatForm;
        PregledKnjigaForm pregledKnjigaForm;
        NovostiForm novostiForm;
        PregledKnjigaZaposlenikForm pregledKnjigaZaposlenikForm;

        public bitBooksMainForm()
        {    
            InitializeComponent();
        }

        private void bitBooksMainForm_Load(object sender, EventArgs e)
        {          
            groupBox3.Visible = false;
            grpAdmin.Visible = false;
            if (Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik)=="Korisnik")
            {
                groupBox3.Visible = true;
            }
            else
            {
                grpAdmin.Visible = true;
                groupBox3.Visible = true;
            }
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            pregledRecenzijaForm = new PregledRecenzijaForm();
            pregledRecenzijaForm.ShowDialog();
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

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            MojeRezervacijeForm rez = new MojeRezervacijeForm();
            rez.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pregledClanovaForm = new PregledClanovaForm();
            pregledClanovaForm.ShowDialog();
        }

        private void btnPosudbe_Click(object sender, EventArgs e)
        {
            MojePosudbeForm pos = new MojePosudbeForm();
            pos.ShowDialog();
        }

        private void btnPregledKnjiga_Click(object sender, EventArgs e)
        {
            pregledKnjigaZaposlenikForm = new PregledKnjigaZaposlenikForm();
            pregledKnjigaZaposlenikForm.ShowDialog();
        }
    }
}
