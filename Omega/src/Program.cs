using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Omega
{
    internal static class Program
    {
        /// <summary>
        /// Method <c>MyClosedHandler</c> closes a program.
        /// </summary>
        public static void MyClosedHandler(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        public static List<Produkt> initialize_products = new List<Produkt>();
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                WebScraper.GetProducts(ConfigReader.getUrl(), initialize_products);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }

        

    }
}
