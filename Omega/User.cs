using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public static class User
    {
        public static int getIdFromNickname() {
            MySqlConnection conn = DatabaseConnection.getConnection();
            var command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = ("select id from user where nickname=@nickname;");
            command.Parameters.AddWithValue("nickname", Login.Nick);
            int id = System.Convert.ToInt32(command.ExecuteScalar().ToString());
            DatabaseConnection.closeConnection();
            return id;
        }

        public static int getNicknameFromID(int id_input)
        {
            MySqlConnection conn = DatabaseConnection.getConnection();
            var command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = ("select nickname from user whereid=@id;");
            command.Parameters.AddWithValue("nickname", id_input);
            int id = System.Convert.ToInt32(command.ExecuteScalar().ToString());
            DatabaseConnection.closeConnection();
            return id;
        }

        public static Boolean validate_login(string nickname, string password)
        {
            var UserExists = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            UserExists.Connection = conn;
            UserExists.CommandText = ("select * from user where nickname=@nickname");
            UserExists.Parameters.AddWithValue("nickname", nickname);
            string dbPassword;
            try
            {
                UserExists.ExecuteNonQuery();
            }
            catch {
                return false;
            }
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(UserExists);
            ad.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("error");
                return false;

            }



            var command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = ("select password from user where nickname=@nickname;");
            command.Parameters.AddWithValue("nickname", nickname);
            
            try
            {
                dbPassword = command.ExecuteScalar().ToString();
            }
            catch {
                return false;
            }
            DatabaseConnection.closeConnection();
            if (PasswordManipulator.VerifyPassword(password, dbPassword))
            {
                return true;
            }
            return false;



        }

        public static Boolean register(string nickname, string password)
        {
            var exists_nickname_comm = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            exists_nickname_comm.Connection = conn;
            exists_nickname_comm.CommandText = ("select * from user where nickname=@nickname And password=@password");
            exists_nickname_comm.Parameters.AddWithValue("nickname", nickname);
            exists_nickname_comm.Parameters.AddWithValue("password", password);
            try {
                exists_nickname_comm.ExecuteNonQuery();
            }

            catch { return false; }


            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(exists_nickname_comm);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                return false;
            }

            try
            {
                var command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = ("insert into user(nickname,password) values(@nickname,@password);"); ;
                command.Parameters.AddWithValue("nickname", nickname);
                command.Parameters.AddWithValue("password", PasswordManipulator.HashPassword(password));
                command.ExecuteNonQuery();
                DatabaseConnection.closeConnection();
            }

            catch
            {
                MessageBox.Show("Nelze vytvorit uzivatele.");
                return false;
            }

            return true;

        }

    }
    
}
