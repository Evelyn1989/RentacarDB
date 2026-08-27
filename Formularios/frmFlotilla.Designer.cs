using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace RentacarDB.Formularios
{
    partial class frmFlotilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbDatosDelVehiculo = new GroupBox();
            cmbEstado = new ComboBox();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            lblEstado = new Label();
            txtTarifa = new TextBox();
            lblTarifa = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            dgvVehiculos = new DataGridView();
            grbDatos = new GroupBox();
            button2 = new Button();
            grbDatosDelVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            grbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grbDatosDelVehiculo
            // 
            grbDatosDelVehiculo.Controls.Add(cmbEstado);
            grbDatosDelVehiculo.Controls.Add(btnLimpiar);
            grbDatosDelVehiculo.Controls.Add(btnGuardar);
            grbDatosDelVehiculo.Controls.Add(lblEstado);
            grbDatosDelVehiculo.Controls.Add(txtTarifa);
            grbDatosDelVehiculo.Controls.Add(lblTarifa);
            grbDatosDelVehiculo.Controls.Add(txtModelo);
            grbDatosDelVehiculo.Controls.Add(lblModelo);
            grbDatosDelVehiculo.Controls.Add(txtMarca);
            grbDatosDelVehiculo.Controls.Add(lblMarca);
            grbDatosDelVehiculo.Controls.Add(txtPlaca);
            grbDatosDelVehiculo.Controls.Add(lblPlaca);
            grbDatosDelVehiculo.Location = new Point(32, 44);
            grbDatosDelVehiculo.Name = "grbDatosDelVehiculo";
            grbDatosDelVehiculo.Size = new Size(244, 537);
            grbDatosDelVehiculo.TabIndex = 0;
            grbDatosDelVehiculo.TabStop = false;
            grbDatosDelVehiculo.Text = "Datos del Vehiculo";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(15, 442);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(179, 28);
            cmbEstado.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(134, 487);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 44);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            //btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 487);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 44);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            //btnGuardar.Click += btnGuardar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(15, 403);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(15, 353);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(179, 27);
            txtTarifa.TabIndex = 7;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(15, 316);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(45, 20);
            lblTarifa.TabIndex = 6;
            lblTarifa.Text = "Tarifa";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(15, 255);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(179, 27);
            txtModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(15, 218);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(15, 169);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 27);
            txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(15, 132);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(15, 76);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(179, 27);
            txtPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(15, 39);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(44, 20);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(20, 52);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.Size = new Size(674, 284);
            dgvVehiculos.TabIndex = 1;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(dgvVehiculos);
            grbDatos.Location = new Point(305, 44);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(722, 356);
            grbDatos.TabIndex = 2;
            grbDatos.TabStop = false;
            grbDatos.Text = "Informacion de Vehiculos";
            // 
            // button2
            // 
            button2.Location = new Point(851, 531);
            button2.Name = "button2";
            button2.Size = new Size(148, 44);
            button2.TabIndex = 4;
            button2.Text = "&Cerrar";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += button2_Click;
            // 
            // frmFlotilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 751);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(grbDatos);
            Controls.Add(grbDatosDelVehiculo);
            Name = "frmFlotilla";
            Text = "frmFlotilla";
            //Load += frmFlotilla_Load;
            grbDatosDelVehiculo.ResumeLayout(false);
            grbDatosDelVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            grbDatos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDatosDelVehiculo;
        private Label lblEstado;
        private TextBox txtTarifa;
        private Label lblTarifa;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtMarca;
        private Label lblMarca;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private DataGridView dgvVehiculos;
        private GroupBox grbDatos;
        private Button btnGuardar;
        private Button button2;
        private Button btnLimpiar;
        private ComboBox cmbEstado;
    }
}