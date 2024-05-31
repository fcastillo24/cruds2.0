using cruds2._0.Clases.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cruds2._0.Clases.CRUD
{
    internal class ClsCreate
    {
         ClsConexion conexion;

       
        public string Register(string nombre, string usuario, DateTime fechaNacimiento, string contraseña)
        {
            // Establecer una conexión utilizando un bloque `using` para la administración automática de recursos
            using (conexion = new ClsConexion())
            {
                try
                {

                    // Obtener una conexión de la clase de conexión
                    MySqlConnection connection = conexion.GetConnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    // Preparar la instrucción SQL con consulta parametrizada para mayor seguridad
                    string sql = $"INSERT INTO compradores (nombre, usuario, contraseña, fechaNacimiento) VALUES (@nombre, @usuario, @contraseña, @fechaNacimiento)";
                   

                    // Crear un objeto `MySqlCommand`
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    // Agregar parámetros con los tipos de datos adecuados para evitar la inyección SQL
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    // Usar el tipo de dato correcto para `fechaNacimiento` (suponiendo una columna `DateTime`)
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                 
                    return "Registrado con éxito";

                }
                catch (Exception ex)
                {
                    // Registrar el error para depuración y posibles alertas
                    Console.WriteLine($"Error al registrar usuario: {ex.Message}");

                    // Devolver un mensaje de error más informativo al usuario
                    return "Error al registrarse. Consulte el registro para obtener más detalles.";
                }
            }
        }
        public string carrospeli(string VIN, string modelo, string Carro, string año, string conductor, DataGridView tablita)
        {
            // Establecer una conexión utilizando un bloque `using` para la administración automática de recursos
            using (ClsConexion conexion = new ClsConexion())
            {
                try
                {
                    // Obtener una conexión de la clase de conexión
                    MySqlConnection connection = conexion.GetConnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    // Preparar la instrucción SQL con consulta parametrizada para mayor seguridad
                    string sql = $"INSERT INTO peliscarros (vin, carro, modelo, año, conductor) VALUES (@VIN, @Carro, @modelo, @año, @conductor)";

                    // Crear un objeto `MySqlCommand`
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    // Agregar parámetros con los tipos de datos adecuados para evitar la inyección SQL
                    command.Parameters.AddWithValue("@VIN", VIN);
                    command.Parameters.AddWithValue("@Carro", Carro);
                    command.Parameters.AddWithValue("@modelo", modelo);
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@conductor", conductor);

                    // Ejecutar la consulta de inserción
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

                    return "Vehículo y conductor registrados";
                }
                catch (Exception ex)
                {
                    // Registrar el error para depuración y posibles alertas
                    //Console.WriteLine($"Error al registrar vehículo y conductor: {ex.Message}");

                    // Devolver un mensaje de error más informativo al usuario
                    return $"Error al registrarse. Consulte el registro para obtener más detalles.{ex.Message}";
                }
            }
        }



    }
}
