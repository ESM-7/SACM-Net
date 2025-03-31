using System;
using System.Windows.Forms;

namespace SACM_2
{
    public partial class RegistroCitas : Form
    {
        public static string Departamento;
        public static DateTime Fecha;
        public RegistroCitas()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void btn_buscarRegistro_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string TipoDepartamento;
            DateTime fechaRegistro;
            try
            {
                if (cb_departamento.SelectedItem == null)
                {
                    MessageBox.Show("No ha seleccionado el departamento a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtp_fechaRegistro.Value == null)
                {
                    MessageBox.Show("No ha seleccionado una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TipoDepartamento = cb_departamento.SelectedItem.ToString();
                fechaRegistro = dtp_fechaRegistro.Value;
                dtg_registroCitas.DataSource = datos.BuscarRegistros(TipoDepartamento, fechaRegistro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_departamento.SelectedItem == null || dtp_fechaRegistro.Value == null)
                {
                    MessageBox.Show("No se han seleccionado los datos requeridos para imprimir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                fImprimirRegistros formImprimir = new fImprimirRegistros
                {
                    // Pasar los valores seleccionados
                    TipoDepartamento = cb_departamento.SelectedItem.ToString(),
                    FechaRegistro = dtp_fechaRegistro.Value
                };
                formImprimir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
