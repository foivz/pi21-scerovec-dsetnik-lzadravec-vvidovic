using bitBooks_Project.Dorian_Iznimke;
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
    public partial class NovostiUnos : Form
    {
        public NovostiUnos()
        {
            InitializeComponent();
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                //tu umjesto 1 ide knjiznica id
                Novost.NovaNovost(txtNaziv.Text, txtOpis.Text, 1);
            }
            catch (UnosNovostiException ex)
            {

                MessageBox.Show(ex.Poruka);
            }

            Close();
            
        }

    }
}
