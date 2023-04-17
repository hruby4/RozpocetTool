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
        /// <summary>
        /// Method <c>getIdFromNickname</c> gets an Id from user table by active user nickname
        /// </summary>
        /// <returns>
        /// user's id
        /// </returns>
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
        /// <summary>
        /// Method <c>getNicknameFromID</c> gets an nickname from user table by Id
        /// </summary>
        /// <returns>
        /// user's nickname
        /// </returns>
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
        /// <summary>
        /// Method <c>validate_login</c> validates if this nickname and password matches some of the user table
        /// </summary>
        /// <returns>
        /// true if it matches then false
        /// </returns>
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
        /// <summary>
        /// Method <c>register</c> validates if nickname, password and code are valid and then it will insert the nickname and password into user table
        /// </summary>
        
        public static void register(string nickname, string password)
        {
            var exists_nickname_comm = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            exists_nickname_comm.Connection = conn;
            exists_nickname_comm.CommandText = ("select * from user where nickname=@nickname And password=@password");
            exists_nickname_comm.Parameters.AddWithValue("nickname", nickname);
            exists_nickname_comm.Parameters.AddWithValue("password", password);
            exists_nickname_comm.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(exists_nickname_comm);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                throw new Exception("Účet s tímto přihlašovacím jménem už existuje");
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
                throw new Exception("Nelze vytvorit uzivatele.");

            }



        }
        /// <summary>
        /// Method <c>exists</c> validates if some user with this nickname exists
        /// </summary>

        public static void exists(string nickname) {
            var exists_nickname_comm = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            exists_nickname_comm.Connection = conn;
            exists_nickname_comm.CommandText = ("select * from user where nickname=@nickname");
            exists_nickname_comm.Parameters.AddWithValue("nickname", nickname);
            exists_nickname_comm.ExecuteNonQuery();
            conn.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(exists_nickname_comm);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                throw new Exception("Účet s tímto přihlašovacím jménem už existuje");
            }
            
        }

    }
    
}
