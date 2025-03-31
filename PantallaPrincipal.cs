using System;
using System.Windows.Forms;
using System.Configuration;

namespace SACM_2
{
    public partial class PantallaPrincipal : Form
    {
        AgendarCita agendar = new AgendarCita();
        VistaCitas vista = new VistaCitas();
        RegistroCitas registro = new RegistroCitas();

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        public string Conexion()
        {
            // Obtener la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["SACM_2.Properties.Settings.CruzRojaPracticaConnectionString"].ConnectionString;
            return connectionString;
        }

        private void btn_nuevaCita_Click(object sender, EventArgs e)
        {
            agendar.Show();
            this.Hide();
        }

        private void btn_verCitasHoy_Click(object sender, EventArgs e)
        {
            vista.Show();
            this.Hide();
        }

        private void btn_registroCitas_Click(object sender, EventArgs e)
        {
            registro.Show();
            this.Hide();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
