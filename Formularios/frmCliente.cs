using System;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            CargarOpcionesComboBox();
        }

        private void CargarOpcionesComboBox()
        {
            // Opciones de tipo de licencia
            cboTipoLicencia.Items.Clear();
            cboTipoLicencia.Items.Add("Clase A - Particular");
            cboTipoLicencia.Items.Add("Clase B - Mercantil");
            cboTipoLicencia.Items.Add("Clase C - Chofer");
            if (cboTipoLicencia.Items.Count > 0)
                cboTipoLicencia.SelectedIndex = 0;

            // Opciones de estado
            cboEstado.Items.Clear();
            cboEstado.Items.Add("CDMX");
            cboEstado.Items.Add("Jalisco");
            cboEstado.Items.Add("Nuevo León");
            if (cboEstado.Items.Count > 0)
                cboEstado.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar cajas de texto
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

            // Restablecer fechas y combos
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaExpedicion.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now;

            if (cboTipoLicencia.Items.Count > 0) cboTipoLicencia.SelectedIndex = 0;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}