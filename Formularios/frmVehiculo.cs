using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Formularios
{
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
            CargarOpcionesComboBox();
        }

        private void CargarOpcionesComboBox()
        {
            // Transmisión
            cboTransmision.Items.Clear();
            cboTransmision.Items.Add("Automática");
            cboTransmision.Items.Add("Manual / Mecánica");
            cboTransmision.Items.Add("CVT");
            if (cboTransmision.Items.Count > 0) cboTransmision.SelectedIndex = 0;

            // Combustible
            cboCombustible.Items.Clear();
            cboCombustible.Items.Add("Gasolina Regular");
            cboCombustible.Items.Add("Gasolina Súper");
            cboCombustible.Items.Add("Diésel");
            cboCombustible.Items.Add("Híbrido");
            cboCombustible.Items.Add("Eléctrico");
            if (cboCombustible.Items.Count > 0) cboCombustible.SelectedIndex = 0;

            // Categoria / Tipo de Vehículo
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add("Sedán");
            cboCategoria.Items.Add("SUV");
            cboCategoria.Items.Add("Hatchback");
            cboCategoria.Items.Add("Pick-up 4x4");
            cboCategoria.Items.Add("Van / Minivan");
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;

            // Estado del Vehículo
            cboEstadoVehiculo.Items.Clear();
            cboEstadoVehiculo.Items.Add("Disponible");
            cboEstadoVehiculo.Items.Add("En Renta");
            cboEstadoVehiculo.Items.Add("En Mantenimiento");
            cboEstadoVehiculo.Items.Add("Fuera de Servicio");
            if (cboEstadoVehiculo.Items.Count > 0) cboEstadoVehiculo.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnio.Clear();
            txtColor.Clear();
            txtNumeroChasis.Clear();
            txtNumeroMotor.Clear();
            txtKilometraje.Clear();
            txtPrecioRentaDia.Clear();

            if (cboTransmision.Items.Count > 0) cboTransmision.SelectedIndex = 0;
            if (cboCombustible.Items.Count > 0) cboCombustible.SelectedIndex = 0;
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
            if (cboEstadoVehiculo.Items.Count > 0) cboEstadoVehiculo.SelectedIndex = 0;

            dtpUltimoMantenimiento.Value = DateTime.Now;
            dtpVencimientoDekra.Value = DateTime.Now;
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vehículo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
