using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega
{
    public class Produkt:IComparable<Produkt>
    {
        private string name;
        private double price;
        private string jednotka;
        private double count;

        

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Jednotka { get => jednotka; set => jednotka = value; }
        public double Count { get => count; set => count = value; }

        public Produkt(string name,double price,string jednotka, double count) {
            this.Name = name;
            this.Price = price;
            this.jednotka = jednotka;
            this.count = count;

        }

        


        public override string ToString()
        {
            if (Count != 0)
            {
                return Name + " | " + Count.ToString() + Jednotka + " | cena za jednotku : " + Price.ToString() + ",-";
            }
            else {
                return Name;
            }
        }

        public int CompareTo(Produkt other)
        {
            if (other == null)
                return 1;

            else
                return this.Name.CompareTo(other.Name);
        }
    }
}
