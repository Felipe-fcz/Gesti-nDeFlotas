namespace GestiónDeFlotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuVehiculos_Click(object sender, EventArgs e)
        {

        }

        private void menuGestionarVehiculos_Click(object sender, EventArgs e)
        {
            FormularioVehiculos formVehiculos = new FormularioVehiculos();
            formVehiculos.ShowDialog();
        }

        private void menuGestionarConductores_Click(object sender, EventArgs e)
        {
            FormularioConductores formConductores = new FormularioConductores();
            formConductores.ShowDialog();
        }

        private void menuProgramarViajes_Click(object sender, EventArgs e)
        {
            FormularioViajes formViajes = new FormularioViajes();
            formViajes.ShowDialog();
        }

        private void menuGestionarMantenimiento_Click(object sender, EventArgs e)
        {
            FormularioMantenimiento formMantenimiento = new FormularioMantenimiento();
            formMantenimiento.ShowDialog();
        }

        private void menuReporteUso_Click(object sender, EventArgs e)
        {
            FormularioReportes formReportes = new FormularioReportes();
            formReportes.ShowDialog();
        }

        private void menuHistorialMantenimiento_Click(object sender, EventArgs e)
        {
            FormularioReportes formReportes = new FormularioReportes();
            formReportes.tabControlReportes.SelectedIndex = 1; // Mostrar la pestaña de historial
            formReportes.ShowDialog();
        }
    }
}
