using HtmlAgilityPack;
using System.Collections.Generic;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Omega {

 
    public static class WebScraper
    {
        /// <summary>
        /// Method <c>GetProducts</c> gradually gets the type products and passes them to AppendProducts method
        /// </summary>
        public static async void GetProducts(string url,List<Produkt> products)
        {
            var httpClient = new HttpClient();

            try
            {
                var doc = await httpClient.GetStringAsync(url + "/eshop");
                var type_nodes = HtmlNode.CreateNode(doc).SelectNodes("/html/body/div[2]/div/main/div[3]/div/div/div[3]/div/div/ul/li[position()>0]");

                var tasks = new List<Task>();
                foreach (var type in type_nodes)
                {
                    string typeUrl = url + type.SelectSingleNode("a").Attributes["href"].Value;
                    tasks.Add(AppendProducts(products, httpClient, typeUrl));
                }

                await Task.WhenAll(tasks);
            }
            catch {
                throw new Exception("Nelze připojit k internetu.");
            }

        }
        /// <summary>
        /// Method <c>AppendProducts</c> passes all the pages with products of the type to the GetPage method
        /// </summary>
        public static async Task AppendProducts(List<Produkt> products, HttpClient httpClient, string url)
        {
            var i = 0;
            bool cont = true;
            while (cont)
            {
                i++;
                string try_url = url + "?page=" + i.ToString();
                var task = GetPage(products, httpClient, try_url, i,cont);
                await task;
            }
        }
        /// <summary>
        /// Method <c>GetPage</c> scans the page for products and passes them to products list
        /// </summary>
        public static async Task GetPage(List<Produkt> products, HttpClient httpClient, string url, int i,bool cont)
        {
            var prod_doc = await httpClient.GetStringAsync(url);
            HtmlNodeCollection product_nodes = null;
            string[] two_divs = {"https://www.pro-doma.cz/eshop-dlazby-ploty-zahrada-2690?page=", "https://www.pro-doma.cz/eshop-strechy-stresni-okna-2692?page=", "https://www.pro-doma.cz/eshop-dlazby-ploty-zahrada-2690?page=", "https://www.pro-doma.cz/eshop-sucha-stavba-2693"};
            bool match = false;
            foreach (string div in two_divs) 
            {
                if (url == div + i.ToString()){
                    match = true;
                }
            }

            if (match == false)
            {
                product_nodes = HtmlNode.CreateNode(prod_doc).SelectNodes("/html/body/div[2]/div/main/div[3]/div/div/div[2]/div[5]/div/div/section/article[position()>0]");
            }
            else {
                product_nodes = HtmlNode.CreateNode(prod_doc).SelectNodes("/html/body/div[2]/div/main/div[3]/div/div/div[2]/div[6]/div/div/section/article[position()>0]");
            }
            if (product_nodes != null)
            {
                try
                {
                    foreach (var product in product_nodes)
                    {

                        try
                        {
                            string productName = WebUtility.HtmlDecode(product.SelectSingleNode("div[2]/div[1]/h2/a").InnerText);
                            int productPrice = 0;
                            productPrice = System.Convert.ToInt32(product.SelectSingleNode("div[2]/div[3]/div[2]/div/span[1]").InnerText);
                            string jednotka = "ks";
                            products.Add(new Produkt(productName, productPrice, jednotka, 0));
                        }
                        catch
                        {

                            cont = false;
                            break;

                        }
                    }
                }
                catch {
                    ;
                }

            }
            
            else {
                cont = false;
            }

        }

    }

    
}