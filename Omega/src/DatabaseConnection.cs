using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Omega
{
    
    public static class DatabaseConnection
    {
        private static MySqlConnection connection = null;

        /// <summary>
        /// Method <c>getConnectione</c> if connection is not null it creates a new connection from config file and then opens but if not then the connection will be only opened
        /// </summary>
        /// <returns>
        /// connection
        /// </returns>
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
                    return null;
                }
            }
            else {
                connection.Open();

            }
            
            return connection;
        }


        /// <summary>
        /// Method <c>closeConnection</c> closes database connection
        /// </summary>
        public static void closeConnection() {
            if (connection != null) {
                connection.Close();
                connection.Dispose();
            }
        }
    }
 }

