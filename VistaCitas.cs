using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SACM_2
{
    public partial class VistaCitas : Form
    {
        private string confirmacion;
        private string idcita;
        public VistaCitas()
        {
            InitializeComponent();
        }

        public string Conexion()
        {
            // Obtener la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["CruzRojaPracticaConnectionString"].ConnectionString;
            return connectionString;
        }

        private void VistaCitas_Load(object sender, EventArgs e)
        {
            string connectionString = Conexion();
            SqlConnection connection = new SqlConnection(connectionString);

            //Se llama al procedimiento almacenado
            SqlCommand command = new SqlCommand("sp_MostrarInformacionCita", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fechaActual", DateTime.Now);
            //Se crea un adaptador de datos
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //Se crea un DataTable para almacenar los resultados
            DataTable dt = new DataTable();

            //Se llena el DataTable con los datos del procedimiento almacenado
            adapter.Fill(dt);

            //Se asigna el DataTable al DataGridView
            dgv_vistaCitas.DataSource = dt;


            MessageBox.Show("Informacion de la cita se muestra sin errores.");

        }

        private void btn_cerrarRegresar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void btn_eliminarCita_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fecha = DateTime.Now;
                Datos datos = new Datos();



                if (dgv_vistaCitas.SelectedRows.Count >= 0 || !string.IsNullOrEmpty(idcita))
                {
                    if (confirmacion == "Cancelada")
                    {
                        MessageBox.Show("la cita Seleccionada ya fue Cancelada", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        string conexion = Conexion();
                        string idRegistro = idcita;
                        using (SqlConnection sqlConnection = new SqlConnection(conexion))
                        {
                            sqlConnection.Open();
                            SqlCommand command = new SqlCommand("sp_EliminarRegistro", sqlConnection);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@idregistro", Convert.ToInt32(idRegistro));
                            command.ExecuteNonQuery();

                            MessageBox.Show("Cita Cancelada", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgv_vistaCitas.DataSource = datos.ObtenerCitas(fecha);
                            dgv_vistaCitas.ReadOnly = false;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void dgv_vistaCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgv_vistaCitas.Rows[e.RowIndex].Cells[0];
                confirmacion = cell.Value.ToString();
                DataGridViewCell cell2 = dgv_vistaCitas.Rows[e.RowIndex].Cells[1];
                idcita = cell2.Value.ToString();
            }
        }
    }
}
