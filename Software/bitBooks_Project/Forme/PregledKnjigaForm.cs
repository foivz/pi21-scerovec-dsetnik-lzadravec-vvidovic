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
    public partial class PregledKnjigaForm : Form
    {
        public PregledKnjigaForm()
        {
            InitializeComponent();
        }

        private void PregledKnjigaForm_Load(object sender, EventArgs e)
        {
            dgvKnjige.DataSource = Knjiga.DohvatiKnjige();

        }
    }
}
