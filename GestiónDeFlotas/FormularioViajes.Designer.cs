namespace GestiónDeFlotas
{
    partial class FormularioViajes
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
            gbDatosViaje = new GroupBox();
            lblVehiculoViaje = new Label();
            lblConductorViaje = new Label();
            lblRuta = new Label();
            lblFechaSalida = new Label();
            lblHoraSalida = new Label();
            lblFechaLlegada = new Label();
            lblHoraLlegada = new Label();
            cmbVehiculoViaje = new ComboBox();
            cmbConductorViaje = new ComboBox();
            txtRuta = new TextBox();
            dtpFechaSalida = new DateTimePicker();
            dtpHoraSalida = new DateTimePicker();
            dtpFechaLlegada = new DateTimePicker();
            dtpHoraLlegada = new DateTimePicker();
            lblEstadoViaje = new Label();
            cmbEstadoViaje = new ComboBox();
            btnNuevoViaje = new Button();
            btnGuardarViaje = new Button();
            btnActualizarViaje = new Button();
            btnCancelarViaje = new Button();
            dgvViajes = new DataGridView();
            gbDatosViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // gbDatosViaje
            // 
            gbDatosViaje.Controls.Add(dgvViajes);
            gbDatosViaje.Controls.Add(btnCancelarViaje);
            gbDatosViaje.Controls.Add(btnActualizarViaje);
            gbDatosViaje.Controls.Add(btnGuardarViaje);
            gbDatosViaje.Controls.Add(btnNuevoViaje);
            gbDatosViaje.Controls.Add(cmbEstadoViaje);
            gbDatosViaje.Controls.Add(lblEstadoViaje);
            gbDatosViaje.Controls.Add(dtpHoraLlegada);
            gbDatosViaje.Controls.Add(dtpFechaLlegada);
            gbDatosViaje.Controls.Add(dtpHoraSalida);
            gbDatosViaje.Controls.Add(dtpFechaSalida);
            gbDatosViaje.Controls.Add(txtRuta);
            gbDatosViaje.Controls.Add(cmbConductorViaje);
            gbDatosViaje.Controls.Add(cmbVehiculoViaje);
            gbDatosViaje.Controls.Add(lblHoraLlegada);
            gbDatosViaje.Controls.Add(lblFechaLlegada);
            gbDatosViaje.Controls.Add(lblHoraSalida);
            gbDatosViaje.Controls.Add(lblFechaSalida);
            gbDatosViaje.Controls.Add(lblRuta);
            gbDatosViaje.Controls.Add(lblConductorViaje);
            gbDatosViaje.Controls.Add(lblVehiculoViaje);
            gbDatosViaje.Location = new Point(12, 12);
            gbDatosViaje.Name = "gbDatosViaje";
            gbDatosViaje.Size = new Size(767, 426);
            gbDatosViaje.TabIndex = 0;
            gbDatosViaje.TabStop = false;
            gbDatosViaje.Text = "Datos del Viaje";
            // 
            // lblVehiculoViaje
            // 
            lblVehiculoViaje.AutoSize = true;
            lblVehiculoViaje.Location = new Point(19, 37);
            lblVehiculoViaje.Name = "lblVehiculoViaje";
            lblVehiculoViaje.Size = new Size(55, 15);
            lblVehiculoViaje.TabIndex = 0;
            lblVehiculoViaje.Text = "Vehículo:";
            // 
            // lblConductorViaje
            // 
            lblConductorViaje.AutoSize = true;
            lblConductorViaje.Location = new Point(9, 74);
            lblConductorViaje.Name = "lblConductorViaje";
            lblConductorViaje.Size = new Size(67, 15);
            lblConductorViaje.TabIndex = 1;
            lblConductorViaje.Text = "Conductor:";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(19, 117);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(34, 15);
            lblRuta.TabIndex = 2;
            lblRuta.Text = "Ruta:";
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(0, 167);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(91, 15);
            lblFechaSalida.TabIndex = 3;
            lblFechaSalida.Text = "Fecha de Salida:";
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Location = new Point(0, 229);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(86, 15);
            lblHoraSalida.TabIndex = 4;
            lblHoraSalida.Text = "Hora de Salida:";
            // 
            // lblFechaLlegada
            // 
            lblFechaLlegada.AutoSize = true;
            lblFechaLlegada.Location = new Point(325, 167);
            lblFechaLlegada.Name = "lblFechaLlegada";
            lblFechaLlegada.Size = new Size(101, 15);
            lblFechaLlegada.TabIndex = 5;
            lblFechaLlegada.Text = "Fecha de Llegada:";
            // 
            // lblHoraLlegada
            // 
            lblHoraLlegada.AutoSize = true;
            lblHoraLlegada.Location = new Point(330, 235);
            lblHoraLlegada.Name = "lblHoraLlegada";
            lblHoraLlegada.Size = new Size(96, 15);
            lblHoraLlegada.TabIndex = 6;
            lblHoraLlegada.Text = "Hora de Llegada:";
            // 
            // cmbVehiculoViaje
            // 
            cmbVehiculoViaje.FormattingEnabled = true;
            cmbVehiculoViaje.Location = new Point(80, 34);
            cmbVehiculoViaje.Name = "cmbVehiculoViaje";
            cmbVehiculoViaje.Size = new Size(121, 23);
            cmbVehiculoViaje.TabIndex = 7;
            // 
            // cmbConductorViaje
            // 
            cmbConductorViaje.FormattingEnabled = true;
            cmbConductorViaje.Location = new Point(82, 71);
            cmbConductorViaje.Name = "cmbConductorViaje";
            cmbConductorViaje.Size = new Size(121, 23);
            cmbConductorViaje.TabIndex = 8;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(82, 117);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(100, 23);
            txtRuta.TabIndex = 9;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(97, 161);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(200, 23);
            dtpFechaSalida.TabIndex = 10;
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.CustomFormat = "";
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(97, 223);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(200, 23);
            dtpHoraSalida.TabIndex = 11;
            // 
            // dtpFechaLlegada
            // 
            dtpFechaLlegada.Location = new Point(442, 161);
            dtpFechaLlegada.Name = "dtpFechaLlegada";
            dtpFechaLlegada.Size = new Size(200, 23);
            dtpFechaLlegada.TabIndex = 12;
            // 
            // dtpHoraLlegada
            // 
            dtpHoraLlegada.Format = DateTimePickerFormat.Time;
            dtpHoraLlegada.Location = new Point(442, 227);
            dtpHoraLlegada.Name = "dtpHoraLlegada";
            dtpHoraLlegada.ShowUpDown = true;
            dtpHoraLlegada.Size = new Size(200, 23);
            dtpHoraLlegada.TabIndex = 13;
            // 
            // lblEstadoViaje
            // 
            lblEstadoViaje.AutoSize = true;
            lblEstadoViaje.Location = new Point(19, 279);
            lblEstadoViaje.Name = "lblEstadoViaje";
            lblEstadoViaje.Size = new Size(45, 15);
            lblEstadoViaje.TabIndex = 14;
            lblEstadoViaje.Text = "Estado:";
            // 
            // cmbEstadoViaje
            // 
            cmbEstadoViaje.FormattingEnabled = true;
            cmbEstadoViaje.Items.AddRange(new object[] { "Programado", "Completado", "Cancelado" });
            cmbEstadoViaje.Location = new Point(82, 279);
            cmbEstadoViaje.Name = "cmbEstadoViaje";
            cmbEstadoViaje.Size = new Size(121, 23);
            cmbEstadoViaje.TabIndex = 15;
            // 
            // btnNuevoViaje
            // 
            btnNuevoViaje.Location = new Point(201, 333);
            btnNuevoViaje.Name = "btnNuevoViaje";
            btnNuevoViaje.Size = new Size(75, 23);
            btnNuevoViaje.TabIndex = 16;
            btnNuevoViaje.Text = "Nuevo";
            btnNuevoViaje.UseVisualStyleBackColor = true;
            // 
            // btnGuardarViaje
            // 
            btnGuardarViaje.Location = new Point(323, 333);
            btnGuardarViaje.Name = "btnGuardarViaje";
            btnGuardarViaje.Size = new Size(75, 23);
            btnGuardarViaje.TabIndex = 17;
            btnGuardarViaje.Text = "Guardar";
            btnGuardarViaje.UseVisualStyleBackColor = true;
            // 
            // btnActualizarViaje
            // 
            btnActualizarViaje.Location = new Point(201, 378);
            btnActualizarViaje.Name = "btnActualizarViaje";
            btnActualizarViaje.Size = new Size(75, 23);
            btnActualizarViaje.TabIndex = 18;
            btnActualizarViaje.Text = "Actualizar";
            btnActualizarViaje.UseVisualStyleBackColor = true;
            // 
            // btnCancelarViaje
            // 
            btnCancelarViaje.Location = new Point(311, 378);
            btnCancelarViaje.Name = "btnCancelarViaje";
            btnCancelarViaje.Size = new Size(97, 23);
            btnCancelarViaje.TabIndex = 19;
            btnCancelarViaje.Text = "Cancelar Viaje";
            btnCancelarViaje.UseVisualStyleBackColor = true;
            // 
            // dgvViajes
            // 
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(442, 270);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.Size = new Size(240, 150);
            dgvViajes.TabIndex = 20;
            // 
            // FormularioViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbDatosViaje);
            Name = "FormularioViajes";
            Text = "FormularioViajes";
            gbDatosViaje.ResumeLayout(false);
            gbDatosViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosViaje;
        private Label lblHoraLlegada;
        private Label lblFechaLlegada;
        private Label lblHoraSalida;
        private Label lblFechaSalida;
        private Label lblRuta;
        private Label lblConductorViaje;
        private Label lblVehiculoViaje;
        private DateTimePicker dtpHoraSalida;
        private DateTimePicker dtpFechaSalida;
        private TextBox txtRuta;
        private ComboBox cmbConductorViaje;
        private ComboBox cmbVehiculoViaje;
        private DateTimePicker dtpHoraLlegada;
        private DateTimePicker dtpFechaLlegada;
        private DataGridView dgvViajes;
        private Button btnCancelarViaje;
        private Button btnActualizarViaje;
        private Button btnGuardarViaje;
        private Button btnNuevoViaje;
        private ComboBox cmbEstadoViaje;
        private Label lblEstadoViaje;
    }
}