using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Data
{
    internal class Connection
    {

        public static String server = "127.0.0.1";
        public static String dataBase = "login";
        public static String user = "root";
        public static String pwd = "Octubre200*";
        
        public  static MySqlConnection connMaster = new MySqlConnection();

        
        public static MySqlConnection OpenConnection() {
            try
            {
                // Cadena de conexión
                string connectionString = $"server={server};database={dataBase};user={user};password={pwd};SslMode=none;";

                connMaster = new MySqlConnection(connectionString);
                connMaster.Open();

                if (connMaster.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión Establecida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return connMaster; // Retorna la conexión abierta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Retorna null si hay un fallo
            }



        }

        public static void CloseConnection() {

            try
            {
                if (connMaster != null && connMaster.State == ConnectionState.Open)
                {
                    connMaster.Close();
                    MessageBox.Show("Conexión cerrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
