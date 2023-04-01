using HtmlAgilityPack;
using System.Collections.Generic;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.ComponentModel;

namespace Omega {

 
    public static class WebScraper
    {

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
        public static async Task AppendProducts(List<Produkt> products, HttpClient httpClient, string url)
        {
            var i = 0;
            bool cont = true;
            while (cont)
            {
                i++;
                string try_url = url + "?page=" + i.ToString();
                Console.WriteLine(try_url);
                var task = GetAllPages(products, httpClient, try_url, i,cont);
                await task;
            }
        }

        public static async Task GetAllPages(List<Produkt> products, HttpClient httpClient, string url, int i,bool cont)
        {
            var prod_doc = await httpClient.GetStringAsync(url);
            HtmlNodeCollection product_nodes = null;
            if (url == "https://www.pro-doma.cz/eshop-dlazby-ploty-zahrada-2690?page=" + i.ToString())
            {
                product_nodes = HtmlNode.CreateNode(prod_doc).SelectNodes("/html/body/div[2]/div/main/div[3]/div/div/div[2]/div[6]/div/div/section/article[position()>0]");
            }
            else
            {
                product_nodes = HtmlNode.CreateNode(prod_doc).SelectNodes("/html/body/div[2]/div/main/div[3]/div/div/div[2]/div[5]/div/div/section/article[position()>0]");
            }
            if (product_nodes != null)
            {
                foreach (var product in product_nodes)
                {

                    try
                    {
                        string productName = WebUtility.HtmlDecode(product.SelectSingleNode("div[2]/div[1]/h2/a").InnerText);
                        int productPrice = 0;
                        if (product.SelectSingleNode("div[2]/div[3]/div[2]/div/span[1]") != null)
                        {
                            productPrice = System.Convert.ToInt32(product.SelectSingleNode("div[2]/div[3]/div[2]/div/span[1]").InnerText);
                        }
                        else
                        {
                            productPrice = 0;
                        }
                        string jednotka = "ks";


                        products.Add(new Produkt(productName, productPrice, jednotka, 0));
                    }
                    catch {
                        break;
                        cont = false;
                    }
                }

            }
            
            else {
                cont = true;
            }

        }

    }

    
}