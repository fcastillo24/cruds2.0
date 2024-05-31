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
    internal class ClsDelete
    {
        ClsConexion conexion;
        public String Delete(int id, DataGridView tablita)
        {
            using (var conexion = new ClsConexion())
            {
                try
                {
                    MySqlConnection connection = conexion.GetConnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    String deletecar = " DELETE from peliscarros where Id=@id";
                        MySqlCommand command = new MySqlCommand(deletecar, connection);
                    command.Parameters.AddWithValue("@id", id);
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
                catch (Exception ex) {
                    return $"existe error en {ex.Message}";
                }
            }
        }
    }
}
