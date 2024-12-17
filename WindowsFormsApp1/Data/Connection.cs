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
        public static String pwd = "";
        
        public  static MySqlConnection connMaster = new MySqlConnection();

        
        public static void OpenConnection() { 
        
            string connectionString = $"server={server};database={dataBase};user{user};password={pwd}";
           connMaster = new MySqlConnection(connectionString);
            
            connMaster.Open();

            if (connMaster.State == ConnectionState.Open)
            {

                MessageBox.Show("Conexion Establecida");

            }
            else {
                MessageBox.Show("No se ha establacido la conexion");

            }


          
        }

        public void CloseConnection() { 
        
        
        
        }

    }
}
