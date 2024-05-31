using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cruds2._0.Clases.Conexion
{
    internal class ClsConexion : IDisposable
    {
        private MySqlConnection conexion;
        private String server = "localhost";
        private String database = "carrosusados";
        private String user = "root";
        private String password = "Dirgtp24"; 
        private String cadenaConexion;
        public void Dispose()
        {
            // Compruebe si la conexión está abierta
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                // Cierre la conexión si está abierta
                conexion.Close();
            }

            // Eliminar el objeto de conexión
            if (conexion != null)
            {
                conexion.Dispose();
            }
        }

        public ClsConexion()
        {
            cadenaConexion = $"Server={server}; Database={database}; User Id={user}; Password={password}";

            
        }

        public MySqlConnection GetConnection()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                conexion.Close();
            }
            else
            {
                Console.WriteLine("La conexión ya está abierta"); // Mensaje informativo (opcional)
            }
            return conexion;
        }

    }
}
