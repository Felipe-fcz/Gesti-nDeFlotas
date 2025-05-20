namespace GestiónDeFlotas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip menuStripPrincipal;
            menuVehiculos = new ToolStripMenuItem();
            menuConductores = new ToolStripMenuItem();
            menuGestionarVehiculos = new ToolStripMenuItem();
            menuGestionarConductores = new ToolStripMenuItem();
            menuViajes = new ToolStripMenuItem();
            menuProgramarViajes = new ToolStripMenuItem();
            menuMantenimiento = new ToolStripMenuItem();
            menuGestionarMantenimiento = new ToolStripMenuItem();
            menuReportes = new ToolStripMenuItem();
            menuReporteUso = new ToolStripMenuItem();
            menuHistorialMantenimiento = new ToolStripMenuItem();
            menuStripPrincipal = new MenuStrip();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { menuVehiculos, menuConductores, menuViajes, menuMantenimiento, menuReportes });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(570, 24);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // menuVehiculos
            // 
            menuVehiculos.DropDownItems.AddRange(new ToolStripItem[] { menuGestionarVehiculos });
            menuVehiculos.Name = "menuVehiculos";
            menuVehiculos.Size = new Size(69, 20);
            menuVehiculos.Text = "Vehículos";
            // 
            // menuConductores
            // 
            menuConductores.DropDownItems.AddRange(new ToolStripItem[] { menuGestionarConductores });
            menuConductores.Name = "menuConductores";
            menuConductores.Size = new Size(87, 20);
            menuConductores.Text = "Conductores";
            // 
            // menuGestionarVehiculos
            // 
            menuGestionarVehiculos.Name = "menuGestionarVehiculos";
            menuGestionarVehiculos.Size = new Size(180, 22);
            menuGestionarVehiculos.Text = "Gestionar Vehículos";
            // 
            // menuGestionarConductores
            // 
            menuGestionarConductores.Name = "menuGestionarConductores";
            menuGestionarConductores.Size = new Size(195, 22);
            menuGestionarConductores.Text = "Gestionar Conductores";
            // 
            // menuViajes
            // 
            menuViajes.DropDownItems.AddRange(new ToolStripItem[] { menuProgramarViajes });
            menuViajes.Name = "menuViajes";
            menuViajes.Size = new Size(49, 20);
            menuViajes.Text = "Viajes";
            // 
            // menuProgramarViajes
            // 
            menuProgramarViajes.Name = "menuProgramarViajes";
            menuProgramarViajes.Size = new Size(180, 22);
            menuProgramarViajes.Text = "Programar Viajes";
            // 
            // menuMantenimiento
            // 
            menuMantenimiento.DropDownItems.AddRange(new ToolStripItem[] { menuGestionarMantenimiento });
            menuMantenimiento.Name = "menuMantenimiento";
            menuMantenimiento.Size = new Size(101, 20);
            menuMantenimiento.Text = "Mantenimiento";
            // 
            // menuGestionarMantenimiento
            // 
            menuGestionarMantenimiento.Name = "menuGestionarMantenimiento";
            menuGestionarMantenimiento.Size = new Size(209, 22);
            menuGestionarMantenimiento.Text = "Gestionar Mantenimiento";
            // 
            // menuReportes
            // 
            menuReportes.DropDownItems.AddRange(new ToolStripItem[] { menuReporteUso, menuHistorialMantenimiento });
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(65, 20);
            menuReportes.Text = "Reportes";
            // 
            // menuReporteUso
            // 
            menuReporteUso.Name = "menuReporteUso";
            menuReporteUso.Size = new Size(219, 22);
            menuReporteUso.Text = "Reporte de Uso";
            // 
            // menuHistorialMantenimiento
            // 
            menuHistorialMantenimiento.Name = "menuHistorialMantenimiento";
            menuHistorialMantenimiento.Size = new Size(219, 22);
            menuHistorialMantenimiento.Text = "Historial de Mantenimiento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 355);
            Controls.Add(menuStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            Name = "Form1";
            Text = "Form1";
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem menuVehiculos;
        private ToolStripMenuItem menuGestionarVehiculos;
        private ToolStripMenuItem menuConductores;
        private ToolStripMenuItem menuGestionarConductores;
        private ToolStripMenuItem menuViajes;
        private ToolStripMenuItem menuProgramarViajes;
        private ToolStripMenuItem menuMantenimiento;
        private ToolStripMenuItem menuGestionarMantenimiento;
        private ToolStripMenuItem menuReportes;
        private ToolStripMenuItem menuReporteUso;
        private ToolStripMenuItem menuHistorialMantenimiento;
    }
}
