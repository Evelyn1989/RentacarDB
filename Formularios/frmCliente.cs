using System;
using System.Data;
using System.Windows.Forms;
using MyLibreria2026; 
using RentacarDB.Modelos;

namespace RentaCar
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            CargarOpcionesComboBox();
            CargarTablaClientes(); 
        }

        private void CargarOpcionesComboBox()
        {

            cboTipoLicencia.Items.Clear();
            cboTipoLicencia.Items.Add("B1 - Liviano");
            cboTipoLicencia.Items.Add("B2 - Pesado");
            cboTipoLicencia.Items.Add("A1 - Motocicleta");
            if (cboTipoLicencia.Items.Count > 0)
                cboTipoLicencia.SelectedIndex = 0;

 
            try
            {
                string queryTipoId = "SELECT IdTipoIdentificacion, NombreTipo FROM TipoIdentificacion";
                DataSet ds = Utilitarios.ejecutar(queryTipoId);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cboEstado.DataSource = ds.Tables[0];
                    cboEstado.DisplayMember = "NombreTipo";
                    cboEstado.ValueMember = "IdTipoIdentificacion";
                }
            }
            catch (Exception ex)
            {
             
            }
        }

        private void CargarTablaClientes()
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCurp.Clear(); 
            txtRfc.Clear();
            txtNumeroLicencia.Clear();
            txtTelefonoFijo.Clear();
            txtTelefonoCelular.Clear();
            txtCorreoElectronico.Clear();
            txtCalleNumero.Clear();
            txtColonia.Clear();
            txtCodigoPostal.Clear();
            txtCiudad.Clear();

  
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaExpedicion.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now;

            if (cboTipoLicencia.Items.Count > 0) cboTipoLicencia.SelectedIndex = 0;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txtCurp.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar al menos la Cédula (CURP) y el Nombre del cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
            
                Cliente nuevoCliente = new Cliente
                {
                    Cedula = txtCurp.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellidoPaterno.Text.Trim(),
                    SegundoApellido = txtApellidoMaterno.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Telefono = string.IsNullOrWhiteSpace(txtTelefonoCelular.Text) ? txtTelefonoFijo.Text.Trim() : txtTelefonoCelular.Text.Trim(),
                    Correo = txtCorreoElectronico.Text.Trim(),
                    NumeroLicencia = txtNumeroLicencia.Text.Trim(),
                    FechaVencLicencia = dtpFechaVencimiento.Value,
                    IdTipoIdentificacion = cboEstado.SelectedValue != null ? Convert.ToInt32(cboEstado.SelectedValue) : 1,
                    Sexo = "No Especificado",
                    FechaVencDocumento = dtpFechaExpedicion.Value,
                    Pais = "Costa Rica",
                    Provincia = txtCiudad.Text.Trim(),
                    Canton = txtColonia.Text.Trim(),
                    Distrito = txtCodigoPostal.Text.Trim(),
                    Direccion = txtCalleNumero.Text.Trim()
                };

       
                string fNac = nuevoCliente.FechaNacimiento.Value.ToString("yyyy-MM-dd");
                string fVencLic = nuevoCliente.FechaVencLicencia.Value.ToString("yyyy-MM-dd");
                string fVencDoc = nuevoCliente.FechaVencDocumento.Value.ToString("yyyy-MM-dd");

                string queryInsert = $@"INSERT INTO Cliente 
                    (Cedula, Nombre, Apellido, SegundoApellido, FechaNacimiento, Telefono, 
                     Correo, NumeroLicencia, FechaVencLicencia, IdTipoIdentificacion, 
                     Sexo, FechaVencDocumento, Pais, Provincia, Canton, Distrito, Direccion)
                    VALUES 
                    ('{nuevoCliente.Cedula}', '{nuevoCliente.Nombre}', '{nuevoCliente.Apellido}', '{nuevoCliente.SegundoApellido}', 
                     '{fNac}', '{nuevoCliente.Telefono}', '{nuevoCliente.Correo}', '{nuevoCliente.NumeroLicencia}', 
                     '{fVencLic}', {nuevoCliente.IdTipoIdentificacion}, '{nuevoCliente.Sexo}', '{fVencDoc}', 
                     '{nuevoCliente.Pais}', '{nuevoCliente.Provincia}', '{nuevoCliente.Canton}', '{nuevoCliente.Distrito}', '{nuevoCliente.Direccion}')";

       
                Utilitarios.ejecutar(queryInsert);

                MessageBox.Show("Cliente guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLimpiar_Click(sender, e);
                CargarTablaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente en la base de datos: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}