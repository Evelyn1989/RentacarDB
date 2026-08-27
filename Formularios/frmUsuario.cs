using System;
using System.Data;
using System.Windows.Forms;
using MyLibreria2026;

namespace RentaCar.Formularios
{
    public partial class frmUsuario : Form
    {
        private bool esEdicion = false;

        public frmUsuario()
        {
            InitializeComponent();
            CargarCombos();
            CargarGridUsuarios();
        }

        private void CargarCombos()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;

            try
            {
                string queryPerfiles = "SELECT IdPerfil, NombrePerfil FROM Perfil WHERE Estado = 'Activo'";
                DataSet ds = Utilitarios.ejecutar(queryPerfiles);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cboPerfil.DataSource = ds.Tables[0];
                    cboPerfil.DisplayMember = "NombrePerfil";
                    cboPerfil.ValueMember = "IdPerfil";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar perfiles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarGridUsuarios()
        {
            try
            {
                string query = @"SELECT u.IdUsuario, u.Cedula, u.NombreUsuario, u.Correo, u.Estado, p.NombrePerfil AS Perfil
                                 FROM Usuario u
                                 INNER JOIN Perfil p ON u.IdPerfil = p.IdPerfil";

                DataSet ds = Utilitarios.ejecutar(query);
                if (ds.Tables.Count > 0)
                {
                    dgvUsuarios.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                txtCedula.Text = row.Cells["Cedula"].Value.ToString();
                txtCedula.ReadOnly = true; // Bloquea la cédula en edición
                txtNombreUsuario.Text = row.Cells["NombreUsuario"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                cboEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
                cboPerfil.Text = row.Cells["Perfil"].Value.ToString();

                txtContrasena.Clear(); // La clave se deja vacía si no se desea cambiar
                esEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Por favor complete Cédula y Nombre de Usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idPerfil = cboPerfil.SelectedValue != null ? Convert.ToInt32(cboPerfil.SelectedValue) : 1;
                string estado = cboEstado.SelectedItem != null ? cboEstado.SelectedItem.ToString() : "Activo";

                if (esEdicion)
                {
    
                    string queryUpdate;

                    if (!string.IsNullOrWhiteSpace(txtContrasena.Text))
                    {
            
                        string claveNuevaCodificada = Utilitarios.codificar(txtContrasena.Text.Trim());
                        queryUpdate = $@"UPDATE Usuario 
                                        SET NombreUsuario = '{txtNombreUsuario.Text.Trim()}', 
                                            Contrasena = '{claveNuevaCodificada}', 
                                            Correo = '{txtCorreo.Text.Trim()}', 
                                            Estado = '{estado}', 
                                            IdPerfil = {idPerfil} 
                                        WHERE Cedula = '{txtCedula.Text.Trim()}'";
                    }
                    else
                    {
             
                        queryUpdate = $@"UPDATE Usuario 
                                        SET NombreUsuario = '{txtNombreUsuario.Text.Trim()}', 
                                            Correo = '{txtCorreo.Text.Trim()}', 
                                            Estado = '{estado}', 
                                            IdPerfil = {idPerfil} 
                                        WHERE Cedula = '{txtCedula.Text.Trim()}'";
                    }

                    Utilitarios.ejecutar(queryUpdate);
                    MessageBox.Show("Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
            
                    if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                    {
                        MessageBox.Show("Debe ingresar una contraseña para el nuevo usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string claveCodificada = Utilitarios.codificar(txtContrasena.Text.Trim());

                    string queryInsert = $@"INSERT INTO Usuario (Cedula, NombreUsuario, Contrasena, Correo, Estado, IdPerfil)
                                            VALUES ('{txtCedula.Text.Trim()}', '{txtNombreUsuario.Text.Trim()}', '{claveCodificada}', 
                                                    '{txtCorreo.Text.Trim()}', '{estado}', {idPerfil})";

                    Utilitarios.ejecutar(queryInsert);
                    MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnLimpiar_Click(sender, e);
                CargarGridUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtCedula.ReadOnly = false;
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            txtCorreo.Clear();
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            if (cboPerfil.Items.Count > 0) cboPerfil.SelectedIndex = 0;

            esEdicion = false;
            btnGuardar.Text = "Guardar";
        }
    }
}