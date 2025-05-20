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
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblTipo = new Label();
            txtTipo = new TextBox();
            lblCapacidad = new Label();
            nudCapacidad = new NumericUpDown();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnNuevoVehiculo = new Button();
            btnGuardarVehiculo = new Button();
            btnActualizarVehiculo = new Button();
            btnEliminarVehiculo = new Button();
            lblBuscarVehiculo = new Label();
            txtBuscarVehiculo = new TextBox();
            btnBuscar = new Button();
            dgvVehiculos = new DataGridView();
            gbDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
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
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(6, 32);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 0;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(73, 29);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(9, 66);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(48, 63);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 3;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(9, 104);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 4;
            lblCapacidad.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(81, 102);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(120, 23);
            nudCapacidad.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(10, 136);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Disponible", "En uso", "En mantenimiento" });
            cmbEstado.Location = new Point(61, 133);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 7;
            // 
            // btnNuevoVehiculo
            // 
            btnNuevoVehiculo.Location = new Point(36, 187);
            btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            btnNuevoVehiculo.Size = new Size(75, 23);
            btnNuevoVehiculo.TabIndex = 8;
            btnNuevoVehiculo.Text = "Nuevo";
            btnNuevoVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarVehiculo
            // 
            btnGuardarVehiculo.Location = new Point(215, 187);
            btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            btnGuardarVehiculo.Size = new Size(75, 23);
            btnGuardarVehiculo.TabIndex = 9;
            btnGuardarVehiculo.Text = "Guardar";
            btnGuardarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnActualizarVehiculo
            // 
            btnActualizarVehiculo.Location = new Point(73, 252);
            btnActualizarVehiculo.Name = "btnActualizarVehiculo";
            btnActualizarVehiculo.Size = new Size(75, 23);
            btnActualizarVehiculo.TabIndex = 10;
            btnActualizarVehiculo.Text = "Actualizar";
            btnActualizarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Location = new Point(215, 252);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(75, 23);
            btnEliminarVehiculo.TabIndex = 11;
            btnEliminarVehiculo.Text = "Eliminar";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // lblBuscarVehiculo
            // 
            lblBuscarVehiculo.AutoSize = true;
            lblBuscarVehiculo.Location = new Point(32, 350);
            lblBuscarVehiculo.Name = "lblBuscarVehiculo";
            lblBuscarVehiculo.Size = new Size(116, 15);
            lblBuscarVehiculo.TabIndex = 12;
            lblBuscarVehiculo.Text = "Buscar por Matrícula";
            // 
            // txtBuscarVehiculo
            // 
            txtBuscarVehiculo.Location = new Point(154, 347);
            txtBuscarVehiculo.Name = "txtBuscarVehiculo";
            txtBuscarVehiculo.Size = new Size(100, 23);
            txtBuscarVehiculo.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(107, 386);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(377, 47);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.Size = new Size(240, 150);
            dgvVehiculos.TabIndex = 15;
            // 
            // FormularioVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbDatosVehiculo);
            Name = "FormularioVehiculos";
            Text = "FormularioVehiculos";
            gbDatosVehiculo.ResumeLayout(false);
            gbDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
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