using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTproyectop1
{
    internal class Conexion 
    {
        public static MySqlConnection conectar()
        {
            string servidor = "localhost";
            string bd = "SI"; // tu base de datos
            string usuario = "root";
            string password = "admin";

            string cadenaConexion = "Database=" + bd + ";DataSource=" + servidor +
                                    ";User Id=" + usuario + ";Password=" + password + ";";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                conexionBD.Open();
                MessageBox.Show("✅ Conexión automática a la base de datos establecida correctamente.");
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("❌ Error al conectar con la base de datos: " + ex.Message);
                return null;
            }
        }
    }
    }

