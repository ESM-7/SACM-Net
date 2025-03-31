using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SACM_2
{
    public partial class AgendarCita : Form
    {
        private PrintDocument PD = new PrintDocument();
        private PrintPreviewDialog PPD = new PrintPreviewDialog();
        private int longpaper;
        public string IDCita { get; set; }
        public string DepartamentoCita { get; set; }
        public string Edad { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NumeroTelefono { get; set; }
        public string Sintomas { get; set; }
        public string EnfermedadesPrevias { get; set; }
        public string ConsumeMedicamento { get; set; }
        public string Alergias { get; set; }
        public DateTime FechaCita { get; set; }
        public string HoraCita { get; set; }

        public AgendarCita()
        {
            InitializeComponent();
            PD.BeginPrint += new PrintEventHandler(PD_BeginPrint);
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);

            // Define las columnas del DataGridView
            dataGVFactura.ColumnCount = 3;
            dataGVFactura.Columns[0].Name = "Nombre del Paciente";
            dataGVFactura.Columns[1].Name = "Tipo de Departamento";
            dataGVFactura.Columns[2].Name = "Fecha de la Cita";
        }

        private void changelongpaper()
        {
            int rowcount = dataGVFactura.Rows.Count;
            longpaper = rowcount * 15 + 240;
        }
       
       public string Conexion() => ConfigurationManager.ConnectionStrings["CruzRojaPracticaConnectionString"].ConnectionString;
    
    //@"Data Source =XPG_ESM\ESQL22; Initial Catalog = CruzRojaPractica; Integrated Security = True;";

    private void btn_guardarCita_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Debe completar todos los campos antes de guardar la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuardarDatosFormulario();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_InsertarCitaFechaHora", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        AsignarParametros(command);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cita guardada correctamente.");
                // Agregar los datos al DataGridView
                dataGVFactura.Rows.Add(Nombre, DepartamentoCita, FechaCita.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la cita: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(cb_departamento.Text) &&
                   nud_edadPaciente.Value > 0 &&
                   !string.IsNullOrWhiteSpace(txt_nombrePaciente.Text) &&
                   !string.IsNullOrWhiteSpace(txt_apellidoPaternoPaciente.Text) &&
                   !string.IsNullOrWhiteSpace(txt_apellidoMaternoPaciente.Text) &&
                   !string.IsNullOrWhiteSpace(txt_numeroTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txt_sintomasPaciente.Text) &&
                   !string.IsNullOrWhiteSpace(txt_enfermedadesPrevias.Text) &&
                   !string.IsNullOrWhiteSpace(txt_consumeMedicamentos.Text) &&
                   !string.IsNullOrWhiteSpace(txt_alergiasPaciente.Text) &&
                   !string.IsNullOrWhiteSpace(dtp_fechaCita.Text) &&
                   !string.IsNullOrWhiteSpace(cb_horaCita.Text);
        }

        private void GuardarDatosFormulario()
        {
            DepartamentoCita = cb_departamento.Text;
            Edad = nud_edadPaciente.Text;
            Nombre = txt_nombrePaciente.Text;
            ApellidoPaterno = txt_apellidoPaternoPaciente.Text;
            ApellidoMaterno = txt_apellidoMaternoPaciente.Text;
            NumeroTelefono = txt_numeroTelefono.Text;
            Sintomas = txt_sintomasPaciente.Text;
            EnfermedadesPrevias = txt_enfermedadesPrevias.Text;
            ConsumeMedicamento = txt_consumeMedicamentos.Text;
            Alergias = txt_alergiasPaciente.Text;
            FechaCita = Convert.ToDateTime(dtp_fechaCita.Text);
            HoraCita = cb_horaCita.Text;
        }

        private void AsignarParametros(SqlCommand command)
        {
            command.Parameters.AddWithValue("@TipoDeCita", DepartamentoCita);
            command.Parameters.AddWithValue("@Edad", Edad);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
            command.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
            command.Parameters.AddWithValue("@NumeroTelefono", NumeroTelefono);
            command.Parameters.AddWithValue("@Sintoma", Sintomas);
            command.Parameters.AddWithValue("@TieneEnfermedadesPrevias", EnfermedadesPrevias);
            command.Parameters.AddWithValue("@ConsumeMedicamento", ConsumeMedicamento);
            command.Parameters.AddWithValue("@Alergias", Alergias);
            command.Parameters.AddWithValue("@Hora", HoraCita);
            command.Parameters.AddWithValue("@Fecha", FechaCita);
        }

        private void btn_nuevaCita_Click(object sender, EventArgs e)
        {
            cb_departamento.Text = string.Empty;
            nud_edadPaciente.Value = 0;
            txt_nombrePaciente.Text = string.Empty;
            txt_apellidoPaternoPaciente.Text = string.Empty;
            txt_apellidoMaternoPaciente.Text = string.Empty;
            txt_numeroTelefono.Text = string.Empty;
            txt_sintomasPaciente.Text = string.Empty;
            txt_enfermedadesPrevias.Text = string.Empty;
            txt_consumeMedicamentos.Text = string.Empty;
            txt_alergiasPaciente.Text = string.Empty;
            cb_horaCita.Text = string.Empty;
            dataGVFactura.Rows.Clear();
        }

        private void btn_imprimirCita_Click(object sender, EventArgs e)
        {
            changelongpaper();
            PPD.Document = PD;
            PPD.ShowDialog();
            //PD.Print();
        }

        private void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            PageSettings pagesetup = new PageSettings();
            pagesetup.PaperSize = new PaperSize("Custom", 250, longpaper);
            PD.DefaultPageSettings = pagesetup;
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region ticket prueba 1
            //Font f10 = new Font("Calibri", 10, FontStyle.Regular);
            //Font f12b = new Font("Calibri", 12, FontStyle.Bold);

            //int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            //StringFormat center = new StringFormat();
            //center.Alignment = StringAlignment.Center;

            //int topMargin = 40;
            //int leftMargin = 40;
            //int lineHeight = 20;
            //int sectionSpacing = 20;

            //e.Graphics.DrawString("Detalle de la Cita Médica", f12b, Brushes.Black, centermargin, topMargin, center);

            //for (int row = 0; row < dataGVFactura.RowCount; row++)
            //{
            //    int currentTopMargin = topMargin + (row * sectionSpacing);

            //    var nombreCell = dataGVFactura.Rows[row].Cells[0].Value;
            //    var departamentoCell = dataGVFactura.Rows[row].Cells[1].Value;
            //    var fechaCell = dataGVFactura.Rows[row].Cells[2].Value;

            //    string nombre = nombreCell != null ? nombreCell.ToString() : "";
            //    string departamento = departamentoCell != null ? departamentoCell.ToString() : "";
            //    string fecha = fechaCell != null ? fechaCell.ToString() : "";

            //    e.Graphics.DrawString("Nombre del Paciente:", f12b, Brushes.Black, leftMargin, currentTopMargin);
            //    e.Graphics.DrawString(nombre, f10, Brushes.Black, leftMargin, currentTopMargin + lineHeight);

            //    e.Graphics.DrawString("Tipo de Departamento:", f12b, Brushes.Black, leftMargin, currentTopMargin + 2 * lineHeight);
            //    e.Graphics.DrawString(departamento, f10, Brushes.Black, leftMargin, currentTopMargin + 3 * lineHeight);

            //    e.Graphics.DrawString("Fecha de la Cita:", f12b, Brushes.Black, leftMargin, currentTopMargin + 4 * lineHeight);
            //    e.Graphics.DrawString(fecha, f10, Brushes.Black, leftMargin, currentTopMargin + 5 * lineHeight);

            //}
            #endregion


            Font f10 = new Font("Calibri", 10, FontStyle.Regular);
            Font f12b = new Font("Calibri", 12, FontStyle.Bold);

            int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;

            for (int row = 0; row < dataGVFactura.RowCount; row++)
            {
                var nombreCell = dataGVFactura.Rows[row].Cells[0].Value;
                var departamentoCell = dataGVFactura.Rows[row].Cells[1].Value;
                var fechaCell = dataGVFactura.Rows[row].Cells[2].Value;

                string nombre = nombreCell != null && !string.IsNullOrWhiteSpace(nombreCell.ToString()) ? nombreCell.ToString() : "";
                string departamento = departamentoCell != null && !string.IsNullOrWhiteSpace(departamentoCell.ToString()) ? departamentoCell.ToString() : "";
                string fecha = fechaCell != null && !string.IsNullOrWhiteSpace(fechaCell.ToString()) ? fechaCell.ToString() : "";


                e.Graphics.DrawString("Nombre del Paciente:  ", f12b, Brushes.Black, 0, 40);
                e.Graphics.DrawString(nombre, f10, Brushes.Black, 0, 60);

                e.Graphics.DrawString("Tipo de Departamento:  ", f12b, Brushes.Black, 0, 80);
                e.Graphics.DrawString(departamento, f10, Brushes.Black, 0, 100);

                e.Graphics.DrawString("Fecha de la Cita:  ", f12b, Brushes.Black, 0, 120);
                e.Graphics.DrawString(fecha, f10, Brushes.Black, 0, 140);
            }

        }







        private void btn_volver_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            try
            {
                cb_horaCita.Items.Clear();
                string departamentoSeleccionado = cb_departamento.SelectedItem.ToString();
                DataTable dt = new DataTable();
                dt = datos.Obtenerhoras(dtp_fechaCita.Value, departamentoSeleccionado);
                foreach (DataRow dr in dt.Rows)
                {
                    cb_horaCita.Items.Add(dr[0].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
            // Inicialización necesaria al cargar el formulario
            // Puedes definir las columnas aquí también si no lo has hecho en el constructor
            dataGVFactura.ColumnCount = 3;
            dataGVFactura.Columns[0].Name = "Nombre del Paciente";
            dataGVFactura.Columns[1].Name = "Tipo de Departamento";
            dataGVFactura.Columns[2].Name = "Fecha de la Cita";
            // Inicialización necesaria al cargar el formulario
        }

        private void nud_edadPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es un número o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el ComboBox
            }
        }

        private void txt_nombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es una letra, un espacio o la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el TextBox
            }
        }

        private void txt_apellidoPaternoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es una letra o la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el ComboBox
            }
        }

        private void txt_apellidoMaternoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es una letra o la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el ComboBox
            }
        }

        private void txt_enfermedadesPrevias_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es una letra, un espacio o la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el TextBox
            }
        }

        private void txt_alergiasPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es una letra, un espacio o la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el TextBox
            }
        }

        private void txt_numeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprueba si el carácter es un número o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Si no es ninguno de ellos, se maneja el evento y no se escribe en el ComboBox
            }
        }

        private void cb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Maneja el evento para que no se escriba en el ComboBox
            e.Handled = true;
        }

        private void cb_horaCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Maneja el evento para que no se escriba en el ComboBox
            e.Handled = true;
        }

        private void dtp_fechaCita_ValueChanged(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            try
            {
                cb_horaCita.Items.Clear();
                string departamentoSeleccionado = cb_departamento.SelectedItem.ToString();
                DataTable dt = new DataTable();
                dt = datos.Obtenerhoras(dtp_fechaCita.Value, departamentoSeleccionado);
                foreach (DataRow dr in dt.Rows)
                {
                    cb_horaCita.Items.Add(dr[0].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}