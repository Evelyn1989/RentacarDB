namespace RentaCar
{
    partial class frmCliente
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

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();

            this.gbInformacionLicencia = new System.Windows.Forms.GroupBox();
            this.lblNumeroLicencia = new System.Windows.Forms.Label();
            this.txtNumeroLicencia = new System.Windows.Forms.TextBox();
            this.lblTipoLicencia = new System.Windows.Forms.Label();
            this.cboTipoLicencia = new System.Windows.Forms.ComboBox();
            this.lblFechaExpedicion = new System.Windows.Forms.Label();
            this.dtpFechaExpedicion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();

            this.gbInformacionContacto = new System.Windows.Forms.GroupBox();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.lblTelefonoCelular = new System.Windows.Forms.Label();
            this.txtTelefonoCelular = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();

            this.gbDireccionUbicacion = new System.Windows.Forms.GroupBox();
            this.lblCalleNumero = new System.Windows.Forms.Label();
            this.txtCalleNumero = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();

            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.gbInformacionLicencia.SuspendLayout();
            this.gbInformacionContacto.SuspendLayout();
            this.gbDireccionUbicacion.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // Items del Menú
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.editarToolStripMenuItem.Text = "Editar";
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            this.ayudaToolStripMenuItem.Text = "Ayuda";

            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.gbDatosPersonales.Controls.Add(this.txtApellidoPaterno);
            this.gbDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.gbDatosPersonales.Controls.Add(this.txtApellidoMaterno);
            this.gbDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblCurp);
            this.gbDatosPersonales.Controls.Add(this.txtCurp);
            this.gbDatosPersonales.Controls.Add(this.lblRfc);
            this.gbDatosPersonales.Controls.Add(this.txtRfc);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 35);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(370, 240);
            this.gbDatosPersonales.TabIndex = 1;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";

            // Controles Datos Personales
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 30);
            this.lblNombre.Text = "Nombre";

            this.txtNombre.Location = new System.Drawing.Point(150, 27);
            this.txtNombre.Size = new System.Drawing.Size(200, 24);

            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(12, 62);
            this.lblApellidoPaterno.Text = "Apellido Paterno";

            this.txtApellidoPaterno.Location = new System.Drawing.Point(150, 59);
            this.txtApellidoPaterno.Size = new System.Drawing.Size(200, 24);

            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(12, 94);
            this.lblApellidoMaterno.Text = "Apellido Materno";

            this.txtApellidoMaterno.Location = new System.Drawing.Point(150, 91);
            this.txtApellidoMaterno.Size = new System.Drawing.Size(200, 24);

            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 126);
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";

            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(150, 123);
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(120, 24);

            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(12, 158);
            this.lblCurp.Text = "CURP";

            this.txtCurp.Location = new System.Drawing.Point(150, 155);
            this.txtCurp.Size = new System.Drawing.Size(200, 24);

            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(12, 190);
            this.lblRfc.Text = "RFC";

            this.txtRfc.Location = new System.Drawing.Point(150, 187);
            this.txtRfc.Size = new System.Drawing.Size(200, 24);

            // 
            // gbInformacionLicencia
            // 
            this.gbInformacionLicencia.Controls.Add(this.lblNumeroLicencia);
            this.gbInformacionLicencia.Controls.Add(this.txtNumeroLicencia);
            this.gbInformacionLicencia.Controls.Add(this.lblTipoLicencia);
            this.gbInformacionLicencia.Controls.Add(this.cboTipoLicencia);
            this.gbInformacionLicencia.Controls.Add(this.lblFechaExpedicion);
            this.gbInformacionLicencia.Controls.Add(this.dtpFechaExpedicion);
            this.gbInformacionLicencia.Controls.Add(this.lblFechaVencimiento);
            this.gbInformacionLicencia.Controls.Add(this.dtpFechaVencimiento);
            this.gbInformacionLicencia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbInformacionLicencia.Location = new System.Drawing.Point(395, 35);
            this.gbInformacionLicencia.Name = "gbInformacionLicencia";
            this.gbInformacionLicencia.Size = new System.Drawing.Size(370, 240);
            this.gbInformacionLicencia.TabIndex = 2;
            this.gbInformacionLicencia.TabStop = false;
            this.gbInformacionLicencia.Text = "Información de Licencia";

            // Controles Información de Licencia
            this.lblNumeroLicencia.AutoSize = true;
            this.lblNumeroLicencia.Location = new System.Drawing.Point(12, 30);
            this.lblNumeroLicencia.Text = "Número de Licencia";

            this.txtNumeroLicencia.Location = new System.Drawing.Point(150, 27);
            this.txtNumeroLicencia.Size = new System.Drawing.Size(200, 24);

            this.lblTipoLicencia.AutoSize = true;
            this.lblTipoLicencia.Location = new System.Drawing.Point(12, 62);
            this.lblTipoLicencia.Text = "Tipo de Licencia";

            this.cboTipoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLicencia.Location = new System.Drawing.Point(150, 59);
            this.cboTipoLicencia.Size = new System.Drawing.Size(200, 24);

            this.lblFechaExpedicion.AutoSize = true;
            this.lblFechaExpedicion.Location = new System.Drawing.Point(12, 94);
            this.lblFechaExpedicion.Text = "Fecha de Expedición";

            this.dtpFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaExpedicion.Location = new System.Drawing.Point(150, 91);
            this.dtpFechaExpedicion.Size = new System.Drawing.Size(120, 24);

            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(12, 126);
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";

            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(150, 123);
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(120, 24);

            // 
            // gbInformacionContacto
            // 
            this.gbInformacionContacto.Controls.Add(this.lblTelefonoFijo);
            this.gbInformacionContacto.Controls.Add(this.txtTelefonoFijo);
            this.gbInformacionContacto.Controls.Add(this.lblTelefonoCelular);
            this.gbInformacionContacto.Controls.Add(this.txtTelefonoCelular);
            this.gbInformacionContacto.Controls.Add(this.lblCorreoElectronico);
            this.gbInformacionContacto.Controls.Add(this.txtCorreoElectronico);
            this.gbInformacionContacto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbInformacionContacto.Location = new System.Drawing.Point(12, 285);
            this.gbInformacionContacto.Name = "gbInformacionContacto";
            this.gbInformacionContacto.Size = new System.Drawing.Size(370, 200);
            this.gbInformacionContacto.TabIndex = 3;
            this.gbInformacionContacto.TabStop = false;
            this.gbInformacionContacto.Text = "Información de Contacto";

            // Controles Contacto
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(12, 30);
            this.lblTelefonoFijo.Text = "Teléfono Fijo";

            this.txtTelefonoFijo.Location = new System.Drawing.Point(150, 27);
            this.txtTelefonoFijo.Size = new System.Drawing.Size(200, 24);

            this.lblTelefonoCelular.AutoSize = true;
            this.lblTelefonoCelular.Location = new System.Drawing.Point(12, 62);
            this.lblTelefonoCelular.Text = "Teléfono Celular";

            this.txtTelefonoCelular.Location = new System.Drawing.Point(150, 59);
            this.txtTelefonoCelular.Size = new System.Drawing.Size(200, 24);

            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(12, 94);
            this.lblCorreoElectronico.Text = "Correo Electrónico";

            this.txtCorreoElectronico.Location = new System.Drawing.Point(150, 91);
            this.txtCorreoElectronico.Size = new System.Drawing.Size(200, 24);

            // 
            // gbDireccionUbicacion
            // 
            this.gbDireccionUbicacion.Controls.Add(this.lblCalleNumero);
            this.gbDireccionUbicacion.Controls.Add(this.txtCalleNumero);
            this.gbDireccionUbicacion.Controls.Add(this.lblColonia);
            this.gbDireccionUbicacion.Controls.Add(this.txtColonia);
            this.gbDireccionUbicacion.Controls.Add(this.lblCodigoPostal);
            this.gbDireccionUbicacion.Controls.Add(this.txtCodigoPostal);
            this.gbDireccionUbicacion.Controls.Add(this.lblCiudad);
            this.gbDireccionUbicacion.Controls.Add(this.txtCiudad);
            this.gbDireccionUbicacion.Controls.Add(this.lblEstado);
            this.gbDireccionUbicacion.Controls.Add(this.cboEstado);
            this.gbDireccionUbicacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbDireccionUbicacion.Location = new System.Drawing.Point(395, 285);
            this.gbDireccionUbicacion.Name = "gbDireccionUbicacion";
            this.gbDireccionUbicacion.Size = new System.Drawing.Size(370, 200);
            this.gbDireccionUbicacion.TabIndex = 4;
            this.gbDireccionUbicacion.TabStop = false;
            this.gbDireccionUbicacion.Text = "Dirección de Ubicación";

            // Controles Ubicación
            this.lblCalleNumero.AutoSize = true;
            this.lblCalleNumero.Location = new System.Drawing.Point(12, 30);
            this.lblCalleNumero.Text = "Calle y Número";

            this.txtCalleNumero.Location = new System.Drawing.Point(150, 27);
            this.txtCalleNumero.Size = new System.Drawing.Size(200, 24);

            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(12, 62);
            this.lblColonia.Text = "Colonia";

            this.txtColonia.Location = new System.Drawing.Point(150, 59);
            this.txtColonia.Size = new System.Drawing.Size(200, 24);

            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(12, 94);
            this.lblCodigoPostal.Text = "Código Postal";

            this.txtCodigoPostal.Location = new System.Drawing.Point(150, 91);
            this.txtCodigoPostal.Size = new System.Drawing.Size(200, 24);

            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(12, 126);
            this.lblCiudad.Text = "Ciudad";

            this.txtCiudad.Location = new System.Drawing.Point(150, 123);
            this.txtCiudad.Size = new System.Drawing.Size(200, 24);

            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 158);
            this.lblEstado.Text = "Estado";

            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Location = new System.Drawing.Point(150, 155);
            this.cboEstado.Size = new System.Drawing.Size(200, 24);

            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLimpiar.Location = new System.Drawing.Point(535, 495);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnGuardarCliente.Location = new System.Drawing.Point(645, 495);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(120, 32);
            this.btnGuardarCliente.TabIndex = 6;
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);

            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbDireccionUbicacion);
            this.Controls.Add(this.gbInformacionContacto);
            this.Controls.Add(this.gbInformacionLicencia);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Clientes";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbInformacionLicencia.ResumeLayout(false);
            this.gbInformacionLicencia.PerformLayout();
            this.gbInformacionContacto.ResumeLayout(false);
            this.gbInformacionContacto.PerformLayout();
            this.gbDireccionUbicacion.ResumeLayout(false);
            this.gbDireccionUbicacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;

        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox txtRfc;

        private System.Windows.Forms.GroupBox gbInformacionLicencia;
        private System.Windows.Forms.Label lblNumeroLicencia;
        private System.Windows.Forms.TextBox txtNumeroLicencia;
        private System.Windows.Forms.Label lblTipoLicencia;
        private System.Windows.Forms.ComboBox cboTipoLicencia;
        private System.Windows.Forms.Label lblFechaExpedicion;
        private System.Windows.Forms.DateTimePicker dtpFechaExpedicion;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;

        private System.Windows.Forms.GroupBox gbInformacionContacto;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.Label lblTelefonoCelular;
        private System.Windows.Forms.TextBox txtTelefonoCelular;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;

        private System.Windows.Forms.GroupBox gbDireccionUbicacion;
        private System.Windows.Forms.Label lblCalleNumero;
        private System.Windows.Forms.TextBox txtCalleNumero;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarCliente;
    }
}