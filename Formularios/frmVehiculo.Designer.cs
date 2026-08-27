namespace RentaCar.Formularios
{
    partial class frmVehiculo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();

            this.gbEspecificacionesTecnicas = new System.Windows.Forms.GroupBox();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.cboTransmision = new System.Windows.Forms.ComboBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.cboCombustible = new System.Windows.Forms.ComboBox();
            this.lblNumeroChasis = new System.Windows.Forms.Label();
            this.txtNumeroChasis = new System.Windows.Forms.TextBox();
            this.lblNumeroMotor = new System.Windows.Forms.Label();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.txtKilometraje = new System.Windows.Forms.TextBox();

            this.gbEstadoAlquiler = new System.Windows.Forms.GroupBox();
            this.lblEstadoVehiculo = new System.Windows.Forms.Label();
            this.cboEstadoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblPrecioRentaDia = new System.Windows.Forms.Label();
            this.txtPrecioRentaDia = new System.Windows.Forms.TextBox();
            this.lblUltimoMantenimiento = new System.Windows.Forms.Label();
            this.dtpUltimoMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimientoDekra = new System.Windows.Forms.Label();
            this.dtpVencimientoDekra = new System.Windows.Forms.DateTimePicker();

            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarVehiculo = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            this.gbEspecificacionesTecnicas.SuspendLayout();
            this.gbEstadoAlquiler.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;

            this.archivoToolStripMenuItem.Text = "Archivo";
            this.editarToolStripMenuItem.Text = "Editar";
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            this.ayudaToolStripMenuItem.Text = "Ayuda";

            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.lblPlaca);
            this.gbDatosGenerales.Controls.Add(this.txtPlaca);
            this.gbDatosGenerales.Controls.Add(this.lblMarca);
            this.gbDatosGenerales.Controls.Add(this.txtMarca);
            this.gbDatosGenerales.Controls.Add(this.lblModelo);
            this.gbDatosGenerales.Controls.Add(this.txtModelo);
            this.gbDatosGenerales.Controls.Add(this.lblAnio);
            this.gbDatosGenerales.Controls.Add(this.txtAnio);
            this.gbDatosGenerales.Controls.Add(this.lblColor);
            this.gbDatosGenerales.Controls.Add(this.txtColor);
            this.gbDatosGenerales.Controls.Add(this.lblCategoria);
            this.gbDatosGenerales.Controls.Add(this.cboCategoria);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbDatosGenerales.Location = new System.Drawing.Point(12, 35);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(370, 240);
            this.gbDatosGenerales.TabIndex = 1;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales del Vehículo";

            // Controles Datos Generales
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(12, 30);
            this.lblPlaca.Text = "Número de Placa";

            this.txtPlaca.Location = new System.Drawing.Point(150, 27);
            this.txtPlaca.Size = new System.Drawing.Size(200, 24);

            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 62);
            this.lblMarca.Text = "Marca";

            this.txtMarca.Location = new System.Drawing.Point(150, 59);
            this.txtMarca.Size = new System.Drawing.Size(200, 24);

            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 94);
            this.lblModelo.Text = "Modelo";

            this.txtModelo.Location = new System.Drawing.Point(150, 91);
            this.txtModelo.Size = new System.Drawing.Size(200, 24);

            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(12, 126);
            this.lblAnio.Text = "Año / Modelo";

            this.txtAnio.Location = new System.Drawing.Point(150, 123);
            this.txtAnio.Size = new System.Drawing.Size(200, 24);

            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 158);
            this.lblColor.Text = "Color";

            this.txtColor.Location = new System.Drawing.Point(150, 155);
            this.txtColor.Size = new System.Drawing.Size(200, 24);

            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 190);
            this.lblCategoria.Text = "Categoría / Tipo";

            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(150, 187);
            this.cboCategoria.Size = new System.Drawing.Size(200, 24);

            // 
            // gbEspecificacionesTecnicas
            // 
            this.gbEspecificacionesTecnicas.Controls.Add(this.lblTransmision);
            this.gbEspecificacionesTecnicas.Controls.Add(this.cboTransmision);
            this.gbEspecificacionesTecnicas.Controls.Add(this.lblCombustible);
            this.gbEspecificacionesTecnicas.Controls.Add(this.cboCombustible);
            this.gbEspecificacionesTecnicas.Controls.Add(this.lblNumeroChasis);
            this.gbEspecificacionesTecnicas.Controls.Add(this.txtNumeroChasis);
            this.gbEspecificacionesTecnicas.Controls.Add(this.lblNumeroMotor);
            this.gbEspecificacionesTecnicas.Controls.Add(this.txtNumeroMotor);
            this.gbEspecificacionesTecnicas.Controls.Add(this.lblKilometraje);
            this.gbEspecificacionesTecnicas.Controls.Add(this.txtKilometraje);
            this.gbEspecificacionesTecnicas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbEspecificacionesTecnicas.Location = new System.Drawing.Point(395, 35);
            this.gbEspecificacionesTecnicas.Name = "gbEspecificacionesTecnicas";
            this.gbEspecificacionesTecnicas.Size = new System.Drawing.Size(370, 240);
            this.gbEspecificacionesTecnicas.TabIndex = 2;
            this.gbEspecificacionesTecnicas.TabStop = false;
            this.gbEspecificacionesTecnicas.Text = "Especificaciones Técnicas";

            // Controles Especificaciones
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Location = new System.Drawing.Point(12, 30);
            this.lblTransmision.Text = "Transmisión";

            this.cboTransmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransmision.Location = new System.Drawing.Point(150, 27);
            this.cboTransmision.Size = new System.Drawing.Size(200, 24);

            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(12, 62);
            this.lblCombustible.Text = "Tipo Combustible";

            this.cboCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCombustible.Location = new System.Drawing.Point(150, 59);
            this.cboCombustible.Size = new System.Drawing.Size(200, 24);

            this.lblNumeroChasis.AutoSize = true;
            this.lblNumeroChasis.Location = new System.Drawing.Point(12, 94);
            this.lblNumeroChasis.Text = "N° Chasis / VIN";

            this.txtNumeroChasis.Location = new System.Drawing.Point(150, 91);
            this.txtNumeroChasis.Size = new System.Drawing.Size(200, 24);

            this.lblNumeroMotor.AutoSize = true;
            this.lblNumeroMotor.Location = new System.Drawing.Point(12, 126);
            this.lblNumeroMotor.Text = "Número de Motor";

            this.txtNumeroMotor.Location = new System.Drawing.Point(150, 123);
            this.txtNumeroMotor.Size = new System.Drawing.Size(200, 24);

            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.Location = new System.Drawing.Point(12, 158);
            this.lblKilometraje.Text = "Kilometraje (Km)";

            this.txtKilometraje.Location = new System.Drawing.Point(150, 155);
            this.txtKilometraje.Size = new System.Drawing.Size(200, 24);

            // 
            // gbEstadoAlquiler
            // 
            this.gbEstadoAlquiler.Controls.Add(this.lblEstadoVehiculo);
            this.gbEstadoAlquiler.Controls.Add(this.cboEstadoVehiculo);
            this.gbEstadoAlquiler.Controls.Add(this.lblPrecioRentaDia);
            this.gbEstadoAlquiler.Controls.Add(this.txtPrecioRentaDia);
            this.gbEstadoAlquiler.Controls.Add(this.lblUltimoMantenimiento);
            this.gbEstadoAlquiler.Controls.Add(this.dtpUltimoMantenimiento);
            this.gbEstadoAlquiler.Controls.Add(this.lblVencimientoDekra);
            this.gbEstadoAlquiler.Controls.Add(this.dtpVencimientoDekra);
            this.gbEstadoAlquiler.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbEstadoAlquiler.Location = new System.Drawing.Point(12, 285);
            this.gbEstadoAlquiler.Name = "gbEstadoAlquiler";
            this.gbEstadoAlquiler.Size = new System.Drawing.Size(753, 190);
            this.gbEstadoAlquiler.TabIndex = 3;
            this.gbEstadoAlquiler.TabStop = false;
            this.gbEstadoAlquiler.Text = "Estado y Tarifa de Alquiler";

            // Controles Alquiler
            this.lblEstadoVehiculo.AutoSize = true;
            this.lblEstadoVehiculo.Location = new System.Drawing.Point(12, 30);
            this.lblEstadoVehiculo.Text = "Estado Actual";

            this.cboEstadoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoVehiculo.Location = new System.Drawing.Point(150, 27);
            this.cboEstadoVehiculo.Size = new System.Drawing.Size(200, 24);

            this.lblPrecioRentaDia.AutoSize = true;
            this.lblPrecioRentaDia.Location = new System.Drawing.Point(395, 30);
            this.lblPrecioRentaDia.Text = "Precio Renta / Día";

            this.txtPrecioRentaDia.Location = new System.Drawing.Point(533, 27);
            this.txtPrecioRentaDia.Size = new System.Drawing.Size(200, 24);

            this.lblUltimoMantenimiento.AutoSize = true;
            this.lblUltimoMantenimiento.Location = new System.Drawing.Point(12, 75);
            this.lblUltimoMantenimiento.Text = "Último Mantenimiento";

            this.dtpUltimoMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimoMantenimiento.Location = new System.Drawing.Point(150, 72);
            this.dtpUltimoMantenimiento.Size = new System.Drawing.Size(200, 24);

            this.lblVencimientoDekra.AutoSize = true;
            this.lblVencimientoDekra.Location = new System.Drawing.Point(395, 75);
            this.lblVencimientoDekra.Text = "Revisión Técnica / RTV";

            this.dtpVencimientoDekra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimientoDekra.Location = new System.Drawing.Point(533, 72);
            this.dtpVencimientoDekra.Size = new System.Drawing.Size(200, 24);

            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLimpiar.Location = new System.Drawing.Point(535, 495);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // 
            // btnGuardarVehiculo
            // 
            this.btnGuardarVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnGuardarVehiculo.Location = new System.Drawing.Point(645, 495);
            this.btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            this.btnGuardarVehiculo.Size = new System.Drawing.Size(120, 32);
            this.btnGuardarVehiculo.TabIndex = 5;
            this.btnGuardarVehiculo.Text = "Guardar Auto";
            this.btnGuardarVehiculo.UseVisualStyleBackColor = true;
            this.btnGuardarVehiculo.Click += new System.EventHandler(this.btnGuardarVehiculo_Click);

            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.btnGuardarVehiculo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbEstadoAlquiler);
            this.Controls.Add(this.gbEspecificacionesTecnicas);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Vehículos";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.gbEspecificacionesTecnicas.ResumeLayout(false);
            this.gbEspecificacionesTecnicas.PerformLayout();
            this.gbEstadoAlquiler.ResumeLayout(false);
            this.gbEstadoAlquiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;

        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;

        private System.Windows.Forms.GroupBox gbEspecificacionesTecnicas;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.ComboBox cboTransmision;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.ComboBox cboCombustible;
        private System.Windows.Forms.Label lblNumeroChasis;
        private System.Windows.Forms.TextBox txtNumeroChasis;
        private System.Windows.Forms.Label lblNumeroMotor;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.TextBox txtKilometraje;

        private System.Windows.Forms.GroupBox gbEstadoAlquiler;
        private System.Windows.Forms.Label lblEstadoVehiculo;
        private System.Windows.Forms.ComboBox cboEstadoVehiculo;
        private System.Windows.Forms.Label lblPrecioRentaDia;
        private System.Windows.Forms.TextBox txtPrecioRentaDia;
        private System.Windows.Forms.Label lblUltimoMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpUltimoMantenimiento;
        private System.Windows.Forms.Label lblVencimientoDekra;
        private System.Windows.Forms.DateTimePicker dtpVencimientoDekra;

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarVehiculo;
    }
}