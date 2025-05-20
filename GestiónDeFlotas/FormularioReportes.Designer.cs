namespace GestiónDeFlotas
{
    partial class FormularioReportes
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
            tabControlReportes = new TabControl();
            tabPageUsoVehiculos = new TabPage();
            tabPageHistorialMantenimiento = new TabPage();
            lblReporteUsoFechaInicio = new Label();
            lblReporteUsoFechaFin = new Label();
            dtpReporteUsoFechaInicio = new DateTimePicker();
            dtpReporteUsoFechaFin = new DateTimePicker();
            btnGenerarReporteUso = new Button();
            dgvReporteUso = new DataGridView();
            lblHistorialVehiculo = new Label();
            cmbHistorialVehiculo = new ComboBox();
            btnGenerarHistorialMantenimiento = new Button();
            dataGridView1 = new DataGridView();
            tabControlReportes.SuspendLayout();
            tabPageUsoVehiculos.SuspendLayout();
            tabPageHistorialMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteUso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControlReportes
            // 
            tabControlReportes.Controls.Add(tabPageUsoVehiculos);
            tabControlReportes.Controls.Add(tabPageHistorialMantenimiento);
            tabControlReportes.Location = new Point(21, 12);
            tabControlReportes.Name = "tabControlReportes";
            tabControlReportes.SelectedIndex = 0;
            tabControlReportes.Size = new Size(575, 426);
            tabControlReportes.TabIndex = 0;
            tabControlReportes.Tag = "";
            // 
            // tabPageUsoVehiculos
            // 
            tabPageUsoVehiculos.Controls.Add(dgvReporteUso);
            tabPageUsoVehiculos.Controls.Add(btnGenerarReporteUso);
            tabPageUsoVehiculos.Controls.Add(dtpReporteUsoFechaFin);
            tabPageUsoVehiculos.Controls.Add(dtpReporteUsoFechaInicio);
            tabPageUsoVehiculos.Controls.Add(lblReporteUsoFechaFin);
            tabPageUsoVehiculos.Controls.Add(lblReporteUsoFechaInicio);
            tabPageUsoVehiculos.Location = new Point(4, 24);
            tabPageUsoVehiculos.Name = "tabPageUsoVehiculos";
            tabPageUsoVehiculos.Padding = new Padding(3);
            tabPageUsoVehiculos.Size = new Size(567, 398);
            tabPageUsoVehiculos.TabIndex = 0;
            tabPageUsoVehiculos.Text = "Uso de Vehículos";
            tabPageUsoVehiculos.UseVisualStyleBackColor = true;
            // 
            // tabPageHistorialMantenimiento
            // 
            tabPageHistorialMantenimiento.Controls.Add(dataGridView1);
            tabPageHistorialMantenimiento.Controls.Add(btnGenerarHistorialMantenimiento);
            tabPageHistorialMantenimiento.Controls.Add(cmbHistorialVehiculo);
            tabPageHistorialMantenimiento.Controls.Add(lblHistorialVehiculo);
            tabPageHistorialMantenimiento.Location = new Point(4, 24);
            tabPageHistorialMantenimiento.Name = "tabPageHistorialMantenimiento";
            tabPageHistorialMantenimiento.Padding = new Padding(3);
            tabPageHistorialMantenimiento.Size = new Size(567, 398);
            tabPageHistorialMantenimiento.TabIndex = 1;
            tabPageHistorialMantenimiento.Text = "Historial de Mantenimiento";
            tabPageHistorialMantenimiento.UseVisualStyleBackColor = true;
            // 
            // lblReporteUsoFechaInicio
            // 
            lblReporteUsoFechaInicio.AutoSize = true;
            lblReporteUsoFechaInicio.Location = new Point(23, 37);
            lblReporteUsoFechaInicio.Name = "lblReporteUsoFechaInicio";
            lblReporteUsoFechaInicio.Size = new Size(73, 15);
            lblReporteUsoFechaInicio.TabIndex = 0;
            lblReporteUsoFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblReporteUsoFechaFin
            // 
            lblReporteUsoFechaFin.AutoSize = true;
            lblReporteUsoFechaFin.Location = new Point(23, 85);
            lblReporteUsoFechaFin.Name = "lblReporteUsoFechaFin";
            lblReporteUsoFechaFin.Size = new Size(60, 15);
            lblReporteUsoFechaFin.TabIndex = 1;
            lblReporteUsoFechaFin.Text = "Fecha Fin:";
            // 
            // dtpReporteUsoFechaInicio
            // 
            dtpReporteUsoFechaInicio.Location = new Point(116, 31);
            dtpReporteUsoFechaInicio.Name = "dtpReporteUsoFechaInicio";
            dtpReporteUsoFechaInicio.Size = new Size(200, 23);
            dtpReporteUsoFechaInicio.TabIndex = 2;
            // 
            // dtpReporteUsoFechaFin
            // 
            dtpReporteUsoFechaFin.Location = new Point(116, 77);
            dtpReporteUsoFechaFin.Name = "dtpReporteUsoFechaFin";
            dtpReporteUsoFechaFin.Size = new Size(200, 23);
            dtpReporteUsoFechaFin.TabIndex = 3;
            // 
            // btnGenerarReporteUso
            // 
            btnGenerarReporteUso.Location = new Point(385, 49);
            btnGenerarReporteUso.Name = "btnGenerarReporteUso";
            btnGenerarReporteUso.Size = new Size(138, 30);
            btnGenerarReporteUso.TabIndex = 4;
            btnGenerarReporteUso.Text = "Generar Reporte";
            btnGenerarReporteUso.UseVisualStyleBackColor = true;
            // 
            // dgvReporteUso
            // 
            dgvReporteUso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteUso.Location = new Point(38, 130);
            dgvReporteUso.Name = "dgvReporteUso";
            dgvReporteUso.Size = new Size(485, 237);
            dgvReporteUso.TabIndex = 5;
            // 
            // lblHistorialVehiculo
            // 
            lblHistorialVehiculo.AutoSize = true;
            lblHistorialVehiculo.Location = new Point(43, 52);
            lblHistorialVehiculo.Name = "lblHistorialVehiculo";
            lblHistorialVehiculo.Size = new Size(55, 15);
            lblHistorialVehiculo.TabIndex = 0;
            lblHistorialVehiculo.Text = "Vehículo:";
            // 
            // cmbHistorialVehiculo
            // 
            cmbHistorialVehiculo.FormattingEnabled = true;
            cmbHistorialVehiculo.Location = new Point(104, 49);
            cmbHistorialVehiculo.Name = "cmbHistorialVehiculo";
            cmbHistorialVehiculo.Size = new Size(121, 23);
            cmbHistorialVehiculo.TabIndex = 1;
            // 
            // btnGenerarHistorialMantenimiento
            // 
            btnGenerarHistorialMantenimiento.Location = new Point(59, 89);
            btnGenerarHistorialMantenimiento.Name = "btnGenerarHistorialMantenimiento";
            btnGenerarHistorialMantenimiento.Size = new Size(137, 28);
            btnGenerarHistorialMantenimiento.TabIndex = 2;
            btnGenerarHistorialMantenimiento.Text = "Generar Historial";
            btnGenerarHistorialMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 221);
            dataGridView1.TabIndex = 3;
            // 
            // FormularioReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 469);
            Controls.Add(tabControlReportes);
            Name = "FormularioReportes";
            Text = "FormularioReportes";
            tabControlReportes.ResumeLayout(false);
            tabPageUsoVehiculos.ResumeLayout(false);
            tabPageUsoVehiculos.PerformLayout();
            tabPageHistorialMantenimiento.ResumeLayout(false);
            tabPageHistorialMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteUso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReportes;
        private TabPage tabPageUsoVehiculos;
        private DateTimePicker dtpReporteUsoFechaInicio;
        private Label lblReporteUsoFechaFin;
        private Label lblReporteUsoFechaInicio;
        private TabPage tabPageHistorialMantenimiento;
        private DataGridView dgvReporteUso;
        private Button btnGenerarReporteUso;
        private DateTimePicker dtpReporteUsoFechaFin;
        private DataGridView dataGridView1;
        private Button btnGenerarHistorialMantenimiento;
        private ComboBox cmbHistorialVehiculo;
        private Label lblHistorialVehiculo;
    }
}