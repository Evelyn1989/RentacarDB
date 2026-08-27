using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentacarDB.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flotillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFlotilla pantallaFlotilla = new frmFlotilla();
            pantallaFlotilla.ShowDialog();
        }
    }
}
