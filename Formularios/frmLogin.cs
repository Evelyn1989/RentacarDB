using System;
using System.Data;
using System.Data.SqlClient;
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

                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();

                // Consulta parametrizada: ya no se concatena el texto del usuario dentro del SQL,
                // así se elimina el riesgo de inyección SQL que tenía la versión anterior.
                // NOTA: esto sigue comparando la contraseña en texto plano. Lo ideal es guardar un
                // hash (BCrypt/PBKDF2) en la tabla Usuario y comparar el hash aquí, no el texto plano.
                string consulta =
                    "SELECT IdUsuario, NombreUsuario, IdPerfil " +
                    "FROM Usuario " +
                    "WHERE NombreUsuario = @Usuario " +
                    "AND Contrasena = @Contrasena " +
                    "AND Estado = 'Activo'";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Usuario", usuario),
                    new SqlParameter("@Contrasena", contrasena)
                };

                Utilitarios utilidad = new Utilitarios();

                // Esto asume que Utilitarios tiene (o se le agrega) un método Ejecutar que acepte
                // parámetros de SQL. Si tu Utilitarios.cs solo tiene Ejecutar(string), compárteme
                // ese archivo y te dejo la sobrecarga correspondiente.
                DataSet datos = utilidad.Ejecutar(consulta, parametros);

                if (datos.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Bienvenido al sistema " + usuario,
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
