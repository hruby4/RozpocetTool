using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;


namespace Omega
{
    public static class CodeManipulator
    {
        /// <summary>
        /// Method <c>validate_code</c> checks if the code is in the codes table.
        /// </summary>
        /// <returns>
        /// true if the code is found then false
        /// </returns>
        public static Boolean validate_code(string code)
        {
            var command = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            command.Connection = conn;

            command.CommandText = ("select * from code where c=@code;");
            command.Parameters.AddWithValue("code", code);
            command.ExecuteNonQuery();
            conn.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(command);
            ad.Fill(dt);
            DatabaseConnection.closeConnection();
            if (dt.Rows.Count > 0)
            {

                return true;
            }
            return false;
        }

        /// <summary>
        /// Method <c>used_code</c> checks if the code is in table_used codes.
        /// </summary>
        /// <returns>
        /// true if the code is found then false
        /// </returns>
        public static Boolean used_code(string code)
        {
            var command = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            command.Connection = conn;

            command.CommandText = ("select * from used_code where c=@code;");
            command.Parameters.AddWithValue("code", code);
            command.ExecuteNonQuery();
            conn.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(command);
            ad.Fill(dt);
            DatabaseConnection.closeConnection();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;



        }

        /// <summary>
        /// Method <c>validate_code</c> .
        /// </summary>
        /// <returns>
        /// true if the code is found then false
        /// </returns>
        public static void use(string code) {
            if (!CodeManipulator.validate_code(code))
            {

                if (CodeManipulator.used_code(code))
                {
                    throw new Exception("Tento kod jiz byl pouzit");
                }
                else
                {
                    throw new Exception("Tento kod neexistuje");
                }
            }
            else
            {
                var command = new MySqlCommand();
                MySqlConnection conn = DatabaseConnection.getConnection();
                command.Connection = conn;
                command.CommandText = ("delete from code where c=@code;");
                command.Parameters.AddWithValue("code", code);
                command.ExecuteNonQuery();
                conn.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(command);
                ad.Fill(dt);
                DatabaseConnection.closeConnection();
            }
            
        }

        /// <summary>
        /// Method <c>GenerateCode</c> generates an unique code in format 'XXXX-XXXX-XXXX-XXXX'.
        /// </summary>
        /// <returns>
        /// Generated code
        /// </returns>
        public static string GenerateCode()
        {
            Random random = new Random();
            StringBuilder code = new StringBuilder();
            MySqlConnection conn = DatabaseConnection.getConnection();
            while (true){
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        char c = (char)random.Next('0', 'Z' + 1);
                        if (!char.IsLetterOrDigit(c))
                        {
                            j--;
                            continue;
                        }
                        code.Append(c);
                    }
                    if (i < 3)
                    {
                        code.Append('-');
                    }
                }

                var isGenerated = new MySqlCommand();
                
                isGenerated.Connection = conn;
                isGenerated.CommandText = ("select * from code where c=@code");
                isGenerated.Parameters.AddWithValue("code", code.ToString());
                isGenerated.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(isGenerated);
                ad.Fill(dt);

                var isUsed = new MySqlCommand();

                isUsed.Connection = conn;
                isUsed.CommandText = ("select * from used_code where c=@code");
                isUsed.Parameters.AddWithValue("code", code.ToString());
                isUsed.ExecuteNonQuery();

                DataTable dt2 = new DataTable();
                MySqlDataAdapter ad2 = new MySqlDataAdapter(isUsed);
                ad.Fill(dt);

                if (dt.Rows.Count == 0 && dt2.Rows.Count == 0)
                {
                    var upload = new MySqlCommand();
                    upload.Connection = conn;
                    upload.CommandText = ("insert into code values(@code)");
                    upload.Parameters.AddWithValue("code", code.ToString());
                    upload.ExecuteNonQuery();
                    DatabaseConnection.closeConnection();
                    return code.ToString();
                }

            }
            
        }
    }
}
