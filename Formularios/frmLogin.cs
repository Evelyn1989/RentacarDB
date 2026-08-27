using System;
using System.Data;
using System.Windows.Forms;
using MyLibreria2026;
using RentacarDB.Modelos;

namespace RentaCar.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenaIngresada = txtContrasena.Text.Trim();

  
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasenaIngresada))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
        
                string contrasenaCodificada = Utilitarios.codificar(contrasenaIngresada);

           
                string query = $@"SELECT IdUsuario, NombreUsuario, IdPerfil, Estado 
                                FROM Usuario 
                                WHERE NombreUsuario = '{usuario}' 
                                  AND Contrasena = '{contrasenaCodificada}'";

                DataSet ds = Utilitarios.ejecutar(query);

          
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    string estado = dr["Estado"].ToString();

                    if (!string.Equals(estado, "Activo", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El usuario se encuentra inactivo. Contacte al administrador.",
                                        "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    MessageBox.Show($"¡Bienvenido al sistema RentaCar, {dr["NombreUsuario"]}!", "Acceso Concedido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar con la base de datos: " + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
