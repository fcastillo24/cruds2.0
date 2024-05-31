using cruds2._0.Clases.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cruds2._0.Clases.CRUD
{
    internal class ClsUpdate
    {
        ClsConexion conexion;
        public String Update(String Vin, String Carro, String Modelo, String Año, String Conductor, int id, DataGridView tablita)
        {
            using (var conexion = new ClsConexion())
            {
                try
                {
                    MySqlConnection connection = conexion.GetConnection();

                    // Abrir la conexión si no está abierta
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string updateSql = $"UPDATE peliscarros SET vin=@Vin, carro=@Carro, modelo=@Modelo, año=@Año, conductor=@Conductor WHERE Id=@id";
                    MySqlCommand command = new MySqlCommand(updateSql, connection);

                    // Agregar parámetros con los tipos de datos adecuados para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Vin", Vin);
                    command.Parameters.AddWithValue("@Carro", Carro);
                    command.Parameters.AddWithValue("@Modelo", Modelo);
                    command.Parameters.AddWithValue("@Año", Año);
                    command.Parameters.AddWithValue("@Conductor", Conductor);
                    command.Parameters.AddWithValue("@id", id);

                    // Ejecutar la consulta de actualización
                    command.ExecuteNonQuery();

                    // Consulta SQL para recuperar los datos actualizados
                    string selectSql = "SELECT * FROM peliscarros";

                    // Crear un nuevo objeto `MySqlDataAdapter` para ejecutar la consulta de selección
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectSql, connection);

                    // Crear un `DataTable` para almacenar los datos recuperados
                    DataTable dataTable = new DataTable();

                    // Llenar el `DataTable` con los datos recuperados
                    dataAdapter.Fill(dataTable);

                    // Asignar el `DataTable` como la fuente de datos del `DataGridView`
                    tablita.DataSource = dataTable;

                    // Cerrar la conexión
                    connection.Close();

                    return "Actualización completa";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }

    }
}
