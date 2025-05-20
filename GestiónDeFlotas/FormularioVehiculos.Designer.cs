namespace GestiónDeFlotas
{
    partial class FormularioVehiculos
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
            gbDatosVehiculo = new GroupBox();
            dgvVehiculos = new DataGridView();
            btnBuscar = new Button();
            txtBuscarVehiculo = new TextBox();
            lblBuscarVehiculo = new Label();
            btnEliminarVehiculo = new Button();
            btnActualizarVehiculo = new Button();
            btnGuardarVehiculo = new Button();
            btnNuevoVehiculo = new Button();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            nudCapacidad = new NumericUpDown();
            lblCapacidad = new Label();
            txtTipo = new TextBox();
            lblTipo = new Label();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            gbDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // gbDatosVehiculo
            // 
            gbDatosVehiculo.Controls.Add(dgvVehiculos);
            gbDatosVehiculo.Controls.Add(btnBuscar);
            gbDatosVehiculo.Controls.Add(txtBuscarVehiculo);
            gbDatosVehiculo.Controls.Add(lblBuscarVehiculo);
            gbDatosVehiculo.Controls.Add(btnEliminarVehiculo);
            gbDatosVehiculo.Controls.Add(btnActualizarVehiculo);
            gbDatosVehiculo.Controls.Add(btnGuardarVehiculo);
            gbDatosVehiculo.Controls.Add(btnNuevoVehiculo);
            gbDatosVehiculo.Controls.Add(cmbEstado);
            gbDatosVehiculo.Controls.Add(lblEstado);
            gbDatosVehiculo.Controls.Add(nudCapacidad);
            gbDatosVehiculo.Controls.Add(lblCapacidad);
            gbDatosVehiculo.Controls.Add(txtTipo);
            gbDatosVehiculo.Controls.Add(lblTipo);
            gbDatosVehiculo.Controls.Add(txtMatricula);
            gbDatosVehiculo.Controls.Add(lblMatricula);
            gbDatosVehiculo.Location = new Point(12, 12);
            gbDatosVehiculo.Name = "gbDatosVehiculo";
            gbDatosVehiculo.Size = new Size(675, 426);
            gbDatosVehiculo.TabIndex = 0;
            gbDatosVehiculo.TabStop = false;
            gbDatosVehiculo.Text = "Datos del Vehículo";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(278, 32);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.Size = new Size(373, 361);
            dgvVehiculos.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(82, 360);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarVehiculo
            // 
            txtBuscarVehiculo.Location = new Point(129, 321);
            txtBuscarVehiculo.Name = "txtBuscarVehiculo";
            txtBuscarVehiculo.Size = new Size(100, 23);
            txtBuscarVehiculo.TabIndex = 13;
            // 
            // lblBuscarVehiculo
            // 
            lblBuscarVehiculo.AutoSize = true;
            lblBuscarVehiculo.Location = new Point(7, 324);
            lblBuscarVehiculo.Name = "lblBuscarVehiculo";
            lblBuscarVehiculo.Size = new Size(116, 15);
            lblBuscarVehiculo.TabIndex = 12;
            lblBuscarVehiculo.Text = "Buscar por Matrícula";
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Location = new Point(107, 252);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(75, 23);
            btnEliminarVehiculo.TabIndex = 11;
            btnEliminarVehiculo.Text = "Eliminar";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnActualizarVehiculo
            // 
            btnActualizarVehiculo.Location = new Point(7, 252);
            btnActualizarVehiculo.Name = "btnActualizarVehiculo";
            btnActualizarVehiculo.Size = new Size(75, 23);
            btnActualizarVehiculo.TabIndex = 10;
            btnActualizarVehiculo.Text = "Actualizar";
            btnActualizarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarVehiculo
            // 
            btnGuardarVehiculo.Location = new Point(104, 208);
            btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            btnGuardarVehiculo.Size = new Size(75, 23);
            btnGuardarVehiculo.TabIndex = 9;
            btnGuardarVehiculo.Text = "Guardar";
            btnGuardarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoVehiculo
            // 
            btnNuevoVehiculo.Location = new Point(7, 208);
            btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            btnNuevoVehiculo.Size = new Size(75, 23);
            btnNuevoVehiculo.TabIndex = 8;
            btnNuevoVehiculo.Text = "Nuevo";
            btnNuevoVehiculo.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Disponible", "En uso", "En mantenimiento" });
            cmbEstado.Location = new Point(58, 156);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(7, 159);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(78, 122);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(120, 23);
            nudCapacidad.TabIndex = 5;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(6, 124);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 4;
            lblCapacidad.Text = "Capacidad:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(73, 83);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 86);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(73, 44);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(7, 47);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 0;
            lblMatricula.Text = "Matrícula:";
            // 
            // FormularioVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 449);
            Controls.Add(gbDatosVehiculo);
            Name = "FormularioVehiculos";
            Text = "FormularioVehiculos";
            gbDatosVehiculo.ResumeLayout(false);
            gbDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosVehiculo;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private NumericUpDown nudCapacidad;
        private Label lblCapacidad;
        private TextBox txtTipo;
        private Label lblTipo;
        private DataGridView dgvVehiculos;
        private Button btnBuscar;
        private TextBox txtBuscarVehiculo;
        private Label lblBuscarVehiculo;
        private Button btnEliminarVehiculo;
        private Button btnActualizarVehiculo;
        private Button btnGuardarVehiculo;
        private Button btnNuevoVehiculo;
    }
}