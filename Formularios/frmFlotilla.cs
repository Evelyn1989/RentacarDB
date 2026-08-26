using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentacarDB.Modelos;

namespace RentacarDB.Formularios
{
    public partial class frmFlotilla : Form
    {

        private BindingList<Vehiculo> listaVehiculos = new BindingList<Vehiculo>();

        public frmFlotilla()
        {
            InitializeComponent();
        }

        private void frmFlotilla_Load(object sender, EventArgs e)
        {
            try
            {

                if (cmbEstado != null)
                {
                    cmbEstado.Items.Clear();
                    cmbEstado.Items.Add("Disponible");
                    cmbEstado.Items.Add("Alquilado");
                    cmbEstado.Items.Add("Mantenimiento");
                    cmbEstado.SelectedIndex = 0;
                }


                if (dgvVehiculos != null)
                {
                    dgvVehiculos.DataSource = listaVehiculos;
                    dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void limpiar()
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtTarifa.Clear();

            if (cmbEstado != null && cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            txtPlaca.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
        }

        private void Guardar()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtModelo.Text) ||
                    string.IsNullOrWhiteSpace(txtTarifa.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa) || tarifa <= 0)
                {
                    MessageBox.Show("Ingrese una tarifa diaria válida.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Vehiculo nuevoVehiculo = new Vehiculo
                {
                    Placa = txtPlaca.Text.Trim().ToUpper(),
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    //TarifaDiaria = tarifa,
                    //Disponible = cmbEstado.SelectedItem?.ToString() == "Disponible"
                };


                listaVehiculos.Add(nuevoVehiculo);

                MessageBox.Show("Se crea vehículo " + txtPlaca.Text + " correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}