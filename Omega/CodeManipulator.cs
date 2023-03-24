using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega
{
    public static class CodeManipulator
    {
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

        public static void use(string code) {
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
