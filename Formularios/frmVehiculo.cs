using System;
using System.Data;
using System.Windows.Forms;
using MyLibreria2026;
using RentacarDB.Modelos;

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
       
            cboTransmision.Items.Clear();
            cboTransmision.Items.Add("Automática");
            cboTransmision.Items.Add("Manual / Mecánica");
            cboTransmision.Items.Add("CVT");
            if (cboTransmision.Items.Count > 0) cboTransmision.SelectedIndex = 0;

    
            cboCombustible.Items.Clear();
            cboCombustible.Items.Add("Gasolina Regular");
            cboCombustible.Items.Add("Gasolina Súper");
            cboCombustible.Items.Add("Diésel");
            cboCombustible.Items.Add("Híbrido");
            cboCombustible.Items.Add("Eléctrico");
            if (cboCombustible.Items.Count > 0) cboCombustible.SelectedIndex = 0;

    
            cboEstadoVehiculo.Items.Clear();
            cboEstadoVehiculo.Items.Add("Disponible");
            cboEstadoVehiculo.Items.Add("En Renta");
            cboEstadoVehiculo.Items.Add("En Mantenimiento");
            cboEstadoVehiculo.Items.Add("Fuera de Servicio");
            if (cboEstadoVehiculo.Items.Count > 0) cboEstadoVehiculo.SelectedIndex = 0;

        
            try
            {
                string queryCategorias = "SELECT IdCategoria, NombreCategoria FROM CategoriaVehiculo";
                DataSet dsCat = Utilitarios.ejecutar(queryCategorias);

                if (dsCat.Tables.Count > 0 && dsCat.Tables[0].Rows.Count > 0)
                {
                    cboCategoria.DataSource = dsCat.Tables[0];
                    cboCategoria.DisplayMember = "NombreCategoria";
                    cboCategoria.ValueMember = "IdCategoria";
                }
                else
                {
            
                    cboCategoria.Items.Clear();
                    cboCategoria.Items.Add("Sedán");
                    cboCategoria.Items.Add("SUV");
                    cboCategoria.Items.Add("Hatchback");
                    cboCategoria.Items.Add("Pick-up 4x4");
                    if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las categorías desde la BD: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
   
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("La Placa, Marca y Modelo son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       
            int.TryParse(txtAnio.Text, out int anio);
            decimal.TryParse(txtKilometraje.Text, out decimal kilometraje);
            decimal.TryParse(txtPrecioRentaDia.Text, out decimal precioDia);

    
            int idCategoria = 1;
            if (cboCategoria.SelectedValue != null && int.TryParse(cboCategoria.SelectedValue.ToString(), out int catParsed))
            {
                idCategoria = catParsed;
            }

            try
            {
      
                Vehiculo vehiculo = new Vehiculo
                {
                    Placa = txtPlaca.Text.Trim(),
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Anio = anio > 0 ? anio : DateTime.Now.Year,
                    Kilometraje = kilometraje,
                    Estado = cboEstadoVehiculo.SelectedItem != null ? cboEstadoVehiculo.SelectedItem.ToString() : "Disponible",
                    IdCategoria = idCategoria,
                    IdSucursal = 1, 
                    TipoVehiculo = cboCategoria.Text,
                    Motor = txtNumeroMotor.Text.Trim(),
                    Combustible = cboCombustible.SelectedItem != null ? cboCombustible.SelectedItem.ToString() : "Gasolina",
                    Transmision = cboTransmision.SelectedItem != null ? cboTransmision.SelectedItem.ToString() : "Automática",
                    NumeroPasajeros = 5,
                    NumeroMaletas = 2,
                    Autonomia = "N/A",
                    Calificacion = 5.00m,
                    PrecioPorDia = precioDia,
                    Foto = "sin_foto.png"
                };

            
                string queryInsert = $@"INSERT INTO Vehiculo 
                    (Placa, Marca, Modelo, Anio, Kilometraje, Estado, IdCategoria, IdSucursal, 
                     TipoVehiculo, Motor, Combustible, Transmision, NumeroPasajeros, NumeroMaletas, 
                     Autonomia, Calificacion, PrecioPorDia, Foto)
                    VALUES 
                    ('{vehiculo.Placa}', '{vehiculo.Marca}', '{vehiculo.Modelo}', {vehiculo.Anio}, 
                     {vehiculo.Kilometraje.ToString(System.Globalization.CultureInfo.InvariantCulture)}, 
                     '{vehiculo.Estado}', {vehiculo.IdCategoria}, {vehiculo.IdSucursal}, 
                     '{vehiculo.TipoVehiculo}', '{vehiculo.Motor}', '{vehiculo.Combustible}', '{vehiculo.Transmision}', 
                     {vehiculo.NumeroPasajeros}, {vehiculo.NumeroMaletas}, '{vehiculo.Autonomia}', 
                     {vehiculo.Calificacion.ToString(System.Globalization.CultureInfo.InvariantCulture)}, 
                     {vehiculo.PrecioPorDia.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{vehiculo.Foto}')";

           
                Utilitarios.ejecutar(queryInsert);

                MessageBox.Show("Vehículo registrado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el vehículo en SQL Server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}