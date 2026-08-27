using System;
using System.Windows.Forms;
using RentaCar.Formularios; 

namespace RentaCar
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

        private void flotillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo vehiculo = new frmVehiculo();
            vehiculo.MdiParent = this;
            vehiculo.Show();
        }

       
        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

      
        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

     
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?",
                                              "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}