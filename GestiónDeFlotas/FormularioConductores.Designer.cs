namespace GestiónDeFlotas
{
    partial class FormularioConductores
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
            gbDatosConductor = new GroupBox();
            lblTelefono = new Label();
            lblLicencia = new Label();
            lblNombreConductor = new Label();
            lblBuscarConductor = new Label();
            txtNombreConductor = new TextBox();
            txtTelefono = new TextBox();
            txtLicencia = new TextBox();
            txtBuscarConductor = new TextBox();
            btnNuevoConductor = new Button();
            btnGuardarConductor = new Button();
            btnActualizarConductor = new Button();
            btnEliminarConductor = new Button();
            btnBuscarConductor = new Button();
            dgvConductores = new DataGridView();
            gbDatosConductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConductores).BeginInit();
            SuspendLayout();
            // 
            // gbDatosConductor
            // 
            gbDatosConductor.Controls.Add(dgvConductores);
            gbDatosConductor.Controls.Add(btnBuscarConductor);
            gbDatosConductor.Controls.Add(btnEliminarConductor);
            gbDatosConductor.Controls.Add(btnActualizarConductor);
            gbDatosConductor.Controls.Add(btnGuardarConductor);
            gbDatosConductor.Controls.Add(btnNuevoConductor);
            gbDatosConductor.Controls.Add(txtBuscarConductor);
            gbDatosConductor.Controls.Add(txtLicencia);
            gbDatosConductor.Controls.Add(txtTelefono);
            gbDatosConductor.Controls.Add(txtNombreConductor);
            gbDatosConductor.Controls.Add(lblBuscarConductor);
            gbDatosConductor.Controls.Add(lblNombreConductor);
            gbDatosConductor.Controls.Add(lblLicencia);
            gbDatosConductor.Controls.Add(lblTelefono);
            gbDatosConductor.Location = new Point(12, 12);
            gbDatosConductor.Name = "gbDatosConductor";
            gbDatosConductor.Size = new Size(730, 442);
            gbDatosConductor.TabIndex = 0;
            gbDatosConductor.TabStop = false;
            gbDatosConductor.Text = "Datos del Conductor";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(19, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Location = new Point(19, 107);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(53, 15);
            lblLicencia.TabIndex = 1;
            lblLicencia.Text = "Licencia:";
            // 
            // lblNombreConductor
            // 
            lblNombreConductor.AutoSize = true;
            lblNombreConductor.Location = new Point(19, 55);
            lblNombreConductor.Name = "lblNombreConductor";
            lblNombreConductor.Size = new Size(54, 15);
            lblNombreConductor.TabIndex = 2;
            lblNombreConductor.Text = "Nombre:";
            // 
            // lblBuscarConductor
            // 
            lblBuscarConductor.AutoSize = true;
            lblBuscarConductor.Location = new Point(52, 364);
            lblBuscarConductor.Name = "lblBuscarConductor";
            lblBuscarConductor.Size = new Size(113, 15);
            lblBuscarConductor.TabIndex = 3;
            lblBuscarConductor.Text = "Buscar por Nombre:";
            // 
            // txtNombreConductor
            // 
            txtNombreConductor.Location = new Point(92, 52);
            txtNombreConductor.Name = "txtNombreConductor";
            txtNombreConductor.Size = new Size(100, 23);
            txtNombreConductor.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(92, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtLicencia
            // 
            txtLicencia.Location = new Point(92, 107);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(100, 23);
            txtLicencia.TabIndex = 5;
            // 
            // txtBuscarConductor
            // 
            txtBuscarConductor.Location = new Point(171, 364);
            txtBuscarConductor.Name = "txtBuscarConductor";
            txtBuscarConductor.Size = new Size(100, 23);
            txtBuscarConductor.TabIndex = 6;
            // 
            // btnNuevoConductor
            // 
            btnNuevoConductor.Location = new Point(52, 218);
            btnNuevoConductor.Name = "btnNuevoConductor";
            btnNuevoConductor.Size = new Size(75, 23);
            btnNuevoConductor.TabIndex = 7;
            btnNuevoConductor.Text = "Nuevo";
            btnNuevoConductor.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConductor
            // 
            btnGuardarConductor.Location = new Point(155, 218);
            btnGuardarConductor.Name = "btnGuardarConductor";
            btnGuardarConductor.Size = new Size(75, 23);
            btnGuardarConductor.TabIndex = 8;
            btnGuardarConductor.Text = "Guardar";
            btnGuardarConductor.UseVisualStyleBackColor = true;
            // 
            // btnActualizarConductor
            // 
            btnActualizarConductor.Location = new Point(52, 274);
            btnActualizarConductor.Name = "btnActualizarConductor";
            btnActualizarConductor.Size = new Size(75, 23);
            btnActualizarConductor.TabIndex = 9;
            btnActualizarConductor.Text = "Actualizar";
            btnActualizarConductor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarConductor
            // 
            btnEliminarConductor.Location = new Point(155, 277);
            btnEliminarConductor.Name = "btnEliminarConductor";
            btnEliminarConductor.Size = new Size(75, 23);
            btnEliminarConductor.TabIndex = 10;
            btnEliminarConductor.Text = "Eliminar";
            btnEliminarConductor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarConductor
            // 
            btnBuscarConductor.Location = new Point(125, 405);
            btnBuscarConductor.Name = "btnBuscarConductor";
            btnBuscarConductor.Size = new Size(75, 23);
            btnBuscarConductor.TabIndex = 11;
            btnBuscarConductor.Text = "Buscar";
            btnBuscarConductor.UseVisualStyleBackColor = true;
            // 
            // dgvConductores
            // 
            dgvConductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConductores.Location = new Point(369, 79);
            dgvConductores.Name = "dgvConductores";
            dgvConductores.Size = new Size(240, 150);
            dgvConductores.TabIndex = 12;
            // 
            // FormularioConductores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 454);
            Controls.Add(gbDatosConductor);
            Name = "FormularioConductores";
            Text = "FormularioConductores";
            gbDatosConductor.ResumeLayout(false);
            gbDatosConductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConductores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosConductor;
        private Label lblBuscarConductor;
        private Label lblNombreConductor;
        private Label lblLicencia;
        private Label lblTelefono;
        private Button btnBuscarConductor;
        private Button btnEliminarConductor;
        private Button btnActualizarConductor;
        private Button btnGuardarConductor;
        private Button btnNuevoConductor;
        private TextBox txtBuscarConductor;
        private TextBox txtLicencia;
        private TextBox txtTelefono;
        private TextBox txtNombreConductor;
        private DataGridView dgvConductores;
    }
}