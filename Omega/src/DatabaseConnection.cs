using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Omega
{
    
    public static class DatabaseConnection
    {
        private static MySqlConnection connection = null;


        public static MySqlConnection getConnection() {
            if (connection == null)
            {
                try
                {
                    var connectionString = new MySqlConnectionStringBuilder
                    {

                        Server = ConfigReader.getAddress(),
                        Port = ConfigReader.getPort(),
                        UserID = ConfigReader.getUser(),
                        Password = ConfigReader.getPassword(),
                        Database = ConfigReader.getSchema()
                    };

                    connection = new MySqlConnection(connectionString.ConnectionString);
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Špatné připojení k internetu.");
                }
            }
            else {
                try
                {
                    connection.Open();
                }
                catch {
                    ;
                }
            }
            
            return connection;
        }


        public static void closeConnection() {
            if (connection != null) {
                connection.Close();
                connection.Dispose();
            }
        }
    }
 }

