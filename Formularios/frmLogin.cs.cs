using System;
using System.Data;
using System.Windows.Forms;
using myLibreria2026;
using RentacarDB.Formularios;

namespace RentacarDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim() == "" ||
                    txtContrasena.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Debe ingresar el usuario y la contraseña.",
                        "Campos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string usuario =
                    txtUsuario.Text.Trim().Replace("'", "''");

                string contrasena =
                    txtContrasena.Text.Trim().Replace("'", "''");

                string consulta =
                    "SELECT IdUsuario, NombreUsuario, IdPerfil " +
                    "FROM Usuario " +
                    "WHERE NombreUsuario = '" + usuario + "' " +
                    "AND Contrasena = '" + contrasena + "' " +
                    "AND Estado = 'Activo'";

                Utilitarios utilidad = new Utilitarios();
                DataSet datos = utilidad.Ejecutar(consulta);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Bienvenida al sistema " + txtUsuario.Text,
                        "Acceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    frmMenu menu = new frmMenu();

                    Hide();
                    menu.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "El usuario o la contraseña son incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo validar el usuario: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            btnIngresar_Click(sender, e);
        }
    }
}