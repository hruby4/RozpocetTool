using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega
{
    public class Produkt
    {
        private string name;
        private double price;
        private jednotka_enum jednotka;
        private double count;

        

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public jednotka_enum Jednotka { get => jednotka; set => jednotka = value; }
        public double Count { get => count; set => count = value; }

        public enum jednotka_enum
        {
            ks,
            kg,
            m2,
            m,
            h
        }
        public Produkt(string name,double price,string jednotka, double count) {
            this.Name = name;
            this.Price = price;
            if (jednotka == "ks")
            {
                this.jednotka = jednotka_enum.ks;
            }
            else if (jednotka == "kg")
            {
                this.jednotka = jednotka_enum.kg;
            }
            else if (jednotka == "m2")
            {
                this.jednotka = jednotka_enum.m2;
            }
            else if (jednotka == "m")
            {
                this.jednotka = jednotka_enum.m;
            }
            else if (jednotka == "h")
            {
                this.jednotka = jednotka_enum.h;
            }
            else {
                throw new ArgumentException("Spatna hodnota jednotky");
            }
            this.count = count;

        }

        public override string ToString()
        {
            return Name + " | " + Count.ToString() + Jednotka + " | cena za jednotku : " +  Price.ToString() + ",-";
        }
    }
}
