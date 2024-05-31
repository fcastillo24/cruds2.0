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
    internal class ClsRead
    {
        ClsConexion conexion;
        public void tablitas(DataGridView dataGridView) // No es necesario devolver DataGridView
        {
            using ( conexion = new ClsConexion())
            {
                try
                {
                    var con = conexion.GetConnection(); 
                    string select = $"SELECT * FROM carrosusados.peliscarros"; 
                    MySqlDataAdapter adapter = new MySqlDataAdapter(select, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" error  en {ex.Message}");
                }
            }
        }

        public string login(string Usuario, string Contraseña)
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


                    // Suponiendo que el hash de contraseña se implementa durante el registro
                    string select = $" SELECT usuario, contraseña FROM carrosusados.compradores WHERE usuario = @usuario AND contraseña = @contraseña";
                    var command = new MySqlCommand(select, connection);
                    command.Parameters.AddWithValue("@usuario", Usuario);
                    command.Parameters.AddWithValue("@contraseña",Contraseña);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        connection.Close();
                        return "Bienvenido";
                    }
                    else
                    {
                        return " error Usuario o contraseña incorrectos.";
                    }
                    
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"Error durante el inicio de sesión: {ex. Mensaje}"); Registre el error real para la depuración
                    return $"Error al iniciar sesión. Intente nuevamente. {ex.Message}";
                }
            }
        }

    }
}
