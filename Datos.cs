using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace SACM_2
{
    internal class Datos
    {
        public string Conexion()
        {

            // Obtener la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["CruzRojaPracticaConnectionString"].ConnectionString;
            return connectionString;
        }
        public DataTable ObtenerCitas(DateTime fecha)
        {
            string connectionString = Conexion();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("sp_MostrarInformacionCita", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fechaActual", fecha);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;
        }

        public DataTable BuscarRegistros(string tipoDepartamento, DateTime fecha)
        {
            string conexion;
            try
            {
                conexion = Conexion();
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("sp_MostrarRegistrosDepar", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tipoDepartamento", tipoDepartamento);
                    command.Parameters.AddWithValue("@fechaRegistro", fecha);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }



        }

        public DataTable Obtenerhoras(DateTime fecha, string departamento)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(Conexion()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_CatDepartamento", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@departamento", departamento);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                            return dt;

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
