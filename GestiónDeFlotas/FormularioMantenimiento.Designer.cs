namespace GestiónDeFlotas
{
    partial class FormularioMantenimiento
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
            gbDatosMantenimiento = new GroupBox();
            lblVehiculoMantenimiento = new Label();
            lblFechaMantenimiento = new Label();
            lblTipoMantenimiento = new Label();
            label4lblDescripcionMantenimiento = new Label();
            cmbVehiculoMantenimiento = new ComboBox();
            dtpFechaMantenimiento = new DateTimePicker();
            cmbTipoMantenimiento = new ComboBox();
            txtDescripcionMantenimiento = new TextBox();
            btnNuevoMantenimiento = new Button();
            btnGuardarMantenimiento = new Button();
            dgvMantenimientos = new DataGridView();
            gbDatosMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).BeginInit();
            SuspendLayout();
            // 
            // gbDatosMantenimiento
            // 
            gbDatosMantenimiento.Controls.Add(dgvMantenimientos);
            gbDatosMantenimiento.Controls.Add(btnGuardarMantenimiento);
            gbDatosMantenimiento.Controls.Add(btnNuevoMantenimiento);
            gbDatosMantenimiento.Controls.Add(txtDescripcionMantenimiento);
            gbDatosMantenimiento.Controls.Add(cmbTipoMantenimiento);
            gbDatosMantenimiento.Controls.Add(dtpFechaMantenimiento);
            gbDatosMantenimiento.Controls.Add(cmbVehiculoMantenimiento);
            gbDatosMantenimiento.Controls.Add(label4lblDescripcionMantenimiento);
            gbDatosMantenimiento.Controls.Add(lblTipoMantenimiento);
            gbDatosMantenimiento.Controls.Add(lblFechaMantenimiento);
            gbDatosMantenimiento.Controls.Add(lblVehiculoMantenimiento);
            gbDatosMantenimiento.Location = new Point(12, 12);
            gbDatosMantenimiento.Name = "gbDatosMantenimiento";
            gbDatosMantenimiento.Size = new Size(565, 426);
            gbDatosMantenimiento.TabIndex = 0;
            gbDatosMantenimiento.TabStop = false;
            gbDatosMantenimiento.Text = "Datos del Mantenimiento";
            // 
            // lblVehiculoMantenimiento
            // 
            lblVehiculoMantenimiento.AutoSize = true;
            lblVehiculoMantenimiento.Location = new Point(20, 51);
            lblVehiculoMantenimiento.Name = "lblVehiculoMantenimiento";
            lblVehiculoMantenimiento.Size = new Size(55, 15);
            lblVehiculoMantenimiento.TabIndex = 0;
            lblVehiculoMantenimiento.Text = "Vehículo:";
            // 
            // lblFechaMantenimiento
            // 
            lblFechaMantenimiento.AutoSize = true;
            lblFechaMantenimiento.Location = new Point(20, 103);
            lblFechaMantenimiento.Name = "lblFechaMantenimiento";
            lblFechaMantenimiento.Size = new Size(41, 15);
            lblFechaMantenimiento.TabIndex = 1;
            lblFechaMantenimiento.Text = "Fecha:";
            // 
            // lblTipoMantenimiento
            // 
            lblTipoMantenimiento.AutoSize = true;
            lblTipoMantenimiento.Location = new Point(20, 155);
            lblTipoMantenimiento.Name = "lblTipoMantenimiento";
            lblTipoMantenimiento.Size = new Size(33, 15);
            lblTipoMantenimiento.TabIndex = 2;
            lblTipoMantenimiento.Text = "Tipo:";
            // 
            // label4lblDescripcionMantenimiento
            // 
            label4lblDescripcionMantenimiento.AutoSize = true;
            label4lblDescripcionMantenimiento.Location = new Point(20, 205);
            label4lblDescripcionMantenimiento.Name = "label4lblDescripcionMantenimiento";
            label4lblDescripcionMantenimiento.Size = new Size(72, 15);
            label4lblDescripcionMantenimiento.TabIndex = 3;
            label4lblDescripcionMantenimiento.Text = "Descripción:";
            // 
            // cmbVehiculoMantenimiento
            // 
            cmbVehiculoMantenimiento.FormattingEnabled = true;
            cmbVehiculoMantenimiento.Location = new Point(93, 48);
            cmbVehiculoMantenimiento.Name = "cmbVehiculoMantenimiento";
            cmbVehiculoMantenimiento.Size = new Size(121, 23);
            cmbVehiculoMantenimiento.TabIndex = 4;
            // 
            // dtpFechaMantenimiento
            // 
            dtpFechaMantenimiento.Location = new Point(93, 95);
            dtpFechaMantenimiento.Name = "dtpFechaMantenimiento";
            dtpFechaMantenimiento.Size = new Size(200, 23);
            dtpFechaMantenimiento.TabIndex = 5;
            // 
            // cmbTipoMantenimiento
            // 
            cmbTipoMantenimiento.FormattingEnabled = true;
            cmbTipoMantenimiento.Items.AddRange(new object[] { "Preventivo", "Correctivo" });
            cmbTipoMantenimiento.Location = new Point(93, 147);
            cmbTipoMantenimiento.Name = "cmbTipoMantenimiento";
            cmbTipoMantenimiento.Size = new Size(121, 23);
            cmbTipoMantenimiento.TabIndex = 6;
            // 
            // txtDescripcionMantenimiento
            // 
            txtDescripcionMantenimiento.Location = new Point(126, 197);
            txtDescripcionMantenimiento.Multiline = true;
            txtDescripcionMantenimiento.Name = "txtDescripcionMantenimiento";
            txtDescripcionMantenimiento.ScrollBars = ScrollBars.Vertical;
            txtDescripcionMantenimiento.Size = new Size(100, 23);
            txtDescripcionMantenimiento.TabIndex = 7;
            // 
            // btnNuevoMantenimiento
            // 
            btnNuevoMantenimiento.Location = new Point(20, 253);
            btnNuevoMantenimiento.Name = "btnNuevoMantenimiento";
            btnNuevoMantenimiento.Size = new Size(88, 29);
            btnNuevoMantenimiento.TabIndex = 8;
            btnNuevoMantenimiento.Text = "Nuevo";
            btnNuevoMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMantenimiento
            // 
            btnGuardarMantenimiento.Location = new Point(126, 253);
            btnGuardarMantenimiento.Name = "btnGuardarMantenimiento";
            btnGuardarMantenimiento.Size = new Size(88, 29);
            btnGuardarMantenimiento.TabIndex = 9;
            btnGuardarMantenimiento.Text = "Guardar";
            btnGuardarMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dgvMantenimientos
            // 
            dgvMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimientos.Location = new Point(271, 263);
            dgvMantenimientos.Name = "dgvMantenimientos";
            dgvMantenimientos.Size = new Size(240, 150);
            dgvMantenimientos.TabIndex = 10;
            // 
            // FormularioMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 444);
            Controls.Add(gbDatosMantenimiento);
            Name = "FormularioMantenimiento";
            Text = "FormularioMantenimiento";
            gbDatosMantenimiento.ResumeLayout(false);
            gbDatosMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosMantenimiento;
        private DataGridView dgvMantenimientos;
        private Button btnGuardarMantenimiento;
        private Button btnNuevoMantenimiento;
        private TextBox txtDescripcionMantenimiento;
        private ComboBox cmbTipoMantenimiento;
        private DateTimePicker dtpFechaMantenimiento;
        private ComboBox cmbVehiculoMantenimiento;
        private Label label4lblDescripcionMantenimiento;
        private Label lblTipoMantenimiento;
        private Label lblFechaMantenimiento;
        private Label lblVehiculoMantenimiento;
    }
}