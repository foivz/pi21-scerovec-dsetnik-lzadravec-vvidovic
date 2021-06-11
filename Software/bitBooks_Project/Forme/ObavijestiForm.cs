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
    public partial class ObavijestiForm : Form
    {
        public ObavijestiForm()
        {
            InitializeComponent();
        }

        private void zatvori_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
