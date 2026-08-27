using System.Drawing;
using System.Windows.Forms;

namespace RentaCar
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            registrarseToolStripMenuItem = new ToolStripMenuItem();
            perfilesToolStripMenuItem = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            mostradorToolStripMenuItem = new ToolStripMenuItem();
            catalogosToolStripMenuItem = new ToolStripMenuItem();
            flotillaToolStripMenuItem = new ToolStripMenuItem();
            adicionalesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            manualUsuarioToolStripMenuItem = new ToolStripMenuItem();
            reporteReservasToolStripMenuItem = new ToolStripMenuItem();
            reporteProductosToolStripMenuItem = new ToolStripMenuItem();
            reporteFacturasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem, registrarseToolStripMenuItem, perfilesToolStripMenuItem, reservaToolStripMenuItem, mostradorToolStripMenuItem, catalogosToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 775);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, salirToolStripMenuItem });
            ingresarToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(143, 29);
            ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(210, 30);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(210, 30);
            salirToolStripMenuItem.Text = "Salir";
           // salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // registrarseToolStripMenuItem
            // 
            registrarseToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            registrarseToolStripMenuItem.Size = new Size(143, 29);
            registrarseToolStripMenuItem.Text = "Registrarse";
            // 
            // perfilesToolStripMenuItem
            // 
            perfilesToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            perfilesToolStripMenuItem.Size = new Size(143, 29);
            perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(143, 29);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // mostradorToolStripMenuItem
            // 
            mostradorToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            mostradorToolStripMenuItem.Name = "mostradorToolStripMenuItem";
            mostradorToolStripMenuItem.Size = new Size(143, 29);
            mostradorToolStripMenuItem.Text = "Mostrador";
            // 
            // catalogosToolStripMenuItem
            // 
            catalogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flotillaToolStripMenuItem, adicionalesToolStripMenuItem });
            catalogosToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            catalogosToolStripMenuItem.Size = new Size(143, 29);
            catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // flotillaToolStripMenuItem
            // 
            flotillaToolStripMenuItem.Name = "flotillaToolStripMenuItem";
            flotillaToolStripMenuItem.Size = new Size(224, 30);
            flotillaToolStripMenuItem.Text = "Flotilla";
           // flotillaToolStripMenuItem.Click += flotillaToolStripMenuItem_Click;
            // 
            // adicionalesToolStripMenuItem
            // 
            adicionalesToolStripMenuItem.Name = "adicionalesToolStripMenuItem";
            adicionalesToolStripMenuItem.Size = new Size(224, 30);
            adicionalesToolStripMenuItem.Text = "Adicionales";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualUsuarioToolStripMenuItem, reporteReservasToolStripMenuItem, reporteProductosToolStripMenuItem, reporteFacturasToolStripMenuItem });
            reportesToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(143, 29);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // manualUsuarioToolStripMenuItem
            // 
            manualUsuarioToolStripMenuItem.Name = "manualUsuarioToolStripMenuItem";
            manualUsuarioToolStripMenuItem.Size = new Size(258, 30);
            manualUsuarioToolStripMenuItem.Text = "Manual Usuario";
            // 
            // reporteReservasToolStripMenuItem
            // 
            reporteReservasToolStripMenuItem.Name = "reporteReservasToolStripMenuItem";
            reporteReservasToolStripMenuItem.Size = new Size(258, 30);
            reporteReservasToolStripMenuItem.Text = "Reporte Reservas";
            // 
            // reporteProductosToolStripMenuItem
            // 
            reporteProductosToolStripMenuItem.Name = "reporteProductosToolStripMenuItem";
            reporteProductosToolStripMenuItem.Size = new Size(258, 30);
            reporteProductosToolStripMenuItem.Text = "Reporte Productos";
            // 
            // reporteFacturasToolStripMenuItem
            // 
            reporteFacturasToolStripMenuItem.Name = "reporteFacturasToolStripMenuItem";
            reporteFacturasToolStripMenuItem.Size = new Size(258, 30);
            reporteFacturasToolStripMenuItem.Text = "Reporte Facturas";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            //BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 775);
            ControlBox = false;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem registrarseToolStripMenuItem;
        private ToolStripMenuItem perfilesToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem mostradorToolStripMenuItem;
        private ToolStripMenuItem catalogosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem flotillaToolStripMenuItem;
        private ToolStripMenuItem adicionalesToolStripMenuItem;
        private ToolStripMenuItem manualUsuarioToolStripMenuItem;
        private ToolStripMenuItem reporteReservasToolStripMenuItem;
        private ToolStripMenuItem reporteProductosToolStripMenuItem;
        private ToolStripMenuItem reporteFacturasToolStripMenuItem;
    }
}