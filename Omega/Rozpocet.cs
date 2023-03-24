using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Omega
{
    public class Rozpocet
    {

        private List<Produkt> products;
        private string date;
        private string name_cust;
        private string surname_cust;
        private int id;

        public List<Produkt> Products { get => products; set => products = value; }
        public string Date { get => date; set => date = value; }
        public string Name_cust { get => name_cust; set => name_cust = value; }
        public string Surname_cust { get => surname_cust; set => surname_cust = value; }
        public int Id { get => id; set => id = value; }

        public Rozpocet(List<Produkt> products, int id, string date, string name_cust, string surname_cust )
        {
            this.Products = products;
            this.Date = date;
            this.Name_cust = name_cust;
            this.Surname_cust = surname_cust;
            this.Id = id;
        }

        public static int getLastId()
        {
            MySqlConnection conn = DatabaseConnection.getConnection();
            var command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = ("select max(id) from rozpocet;");
            int id = System.Convert.ToInt32(command.ExecuteScalar().ToString());
            DatabaseConnection.closeConnection();
            
            return id;
        }
        public static bool uploadList(List<Produkt> list_products,string cust_name,string cust_surname)
        {
            int user_id = User.getIdFromNickname();
            var upload_rozpocet = new MySqlCommand();
            MySqlConnection conn = DatabaseConnection.getConnection();
            upload_rozpocet.Connection = conn;
            try
            {
                upload_rozpocet.CommandText = ("INSERT INTO rozpocet (user_id, datum, jmeno_zak, prijmeni_zak) " +
                    "VALUES (@user_id, @date, @cust_name, @cust_surname); " +
                    "SELECT LAST_INSERT_ID();");
                upload_rozpocet.Parameters.AddWithValue("user_id", user_id);
                Console.WriteLine(DateTime.Now.ToString("yyyy-m-d"));
                upload_rozpocet.Parameters.AddWithValue("date", DateTime.Now.ToString("yyyy-MM-dd"));
                upload_rozpocet.Parameters.AddWithValue("cust_name", cust_name);
                upload_rozpocet.Parameters.AddWithValue("cust_surname", cust_surname);

                int rozpocet_id = Convert.ToInt32(upload_rozpocet.ExecuteScalar());

            foreach (Produkt p in list_products)
                {
                    var insert_produkt = new MySqlCommand();
                    insert_produkt.Connection = conn;
                    insert_produkt.CommandText = ("insert into produkt(nazev,rozpocet_id,jednotka,pocet,cena) values(@nazev,@rozpocet_id,@jednotka,@pocet,@cena);"); ;
                    insert_produkt.Parameters.AddWithValue("nazev", p.Name);
                    insert_produkt.Parameters.AddWithValue("rozpocet_id", rozpocet_id);
                    insert_produkt.Parameters.AddWithValue("jednotka", p.Jednotka.ToString());
                    insert_produkt.Parameters.AddWithValue("pocet", p.Count);
                    insert_produkt.Parameters.AddWithValue("cena", p.Price);
                    insert_produkt.ExecuteNonQuery();

                }
                DatabaseConnection.closeConnection();

            }
            catch
            {
                DatabaseConnection.closeConnection();
                MessageBox.Show("Nelze vytvorit rozpocet.");
                return false;
            }




            return true;
        }


        public static List<Rozpocet> GetAllByNickname()
        {
            int user_id = User.getIdFromNickname();
            MySqlConnection conn = DatabaseConnection.getConnection();
            var get_all_Rozpocet = new MySqlCommand();
            List<Rozpocet> rozpocet_list = new List<Rozpocet>();
            get_all_Rozpocet.Connection = conn;
            get_all_Rozpocet.CommandText = ("select id,datum,jmeno_zak,prijmeni_zak from rozpocet where user_id = @user_id");
            get_all_Rozpocet.Parameters.AddWithValue("user_id",user_id);
            try
            {
                MySqlDataReader reader = get_all_Rozpocet.ExecuteReader();
                

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string date = reader.GetMySqlDateTime(1).ToString();
                    string cust_name = reader.GetString(2);
                    string cust_surname = reader.GetString(3);
                    rozpocet_list.Add(new Rozpocet(new List<Produkt>(), id, date, cust_name, cust_surname));
                }


                reader.Close();



                
                foreach (var r in rozpocet_list)
                {
                    var insert_all_Products = new MySqlCommand();
                    insert_all_Products.Connection = conn;
                    insert_all_Products.CommandText = ("select nazev,jednotka,pocet,cena from produkt where rozpocet_id = @rozpocet_id");
                    insert_all_Products.Parameters.AddWithValue("rozpocet_id", r.Id);
                    MySqlDataReader reader2 = insert_all_Products.ExecuteReader();
                    List<Produkt> product_list = new List<Produkt>();

                    while (reader2.Read())
                    {
                        string nazev = reader2.GetString(0);
                        string jednotka = reader2.GetString(1);
                        double pocet = reader2.GetDouble(2);
                        double cena = reader2.GetDouble(3);
                        product_list.Add(new Produkt(nazev, cena, jednotka, pocet));
                    }

                    reader2.Close();
                    r.Products = product_list;
                }
            }
            catch {
                DatabaseConnection.closeConnection();
                throw new Exception("Nelze ziskat rozpocty.");
            }



            DatabaseConnection.closeConnection();
            return rozpocet_list;
        }

        public override string ToString()
        {
            return "Čislo: " + Id.ToString() + " | Zákazník: " + Name_cust + " " + Surname_cust + " | Datum: " + Date;
        }

    }
}
