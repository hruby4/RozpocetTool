using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Omega
{
    public static class ConfigReader
    {
        /// <summary>
        /// Method <c>readFile</c> gets a config json from ../../config/config.conf
        /// </summary>
        /// <returns>
        /// json converted to dictionary
        /// </returns>
        public static Dictionary<string, string> readFile() {
            try {
                string json = System.IO.File.ReadAllText(@"../../config/config.conf");
                return JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            }

            catch {
                return null;
            }
            
        }
        /// <summary>
        /// Method <c>getAddress</c> gets address from readFile() method
        /// </summary>
        /// <returns>
        /// string address from config
        /// </returns>
        public static string getAddress() {
            return readFile()["address"];
        }

        /// <summary>
        /// Method <c>getPort</c> gets port from readFile() method
        /// </summary>
        /// <returns>
        /// UInt32 port from config
        /// </returns>
        public static UInt32 getPort()
        {
            return System.Convert.ToUInt32(readFile()["port"]);
        }
        /// <summary>
        /// Method <c>getUser</c> gets user from readFile() method
        /// </summary>
        /// <returns>
        /// string user from config
        /// </returns>
        public static string getUser()
        {
            return readFile()["user"];
        }
        /// <summary>
        /// Method <c>getPassword</c> gets password from readFile() method
        /// </summary>
        /// <returns>
        /// string password from config
        /// </returns>
        public static string getPassword()
        {
            return readFile()["password"];
        }
        /// <summary>
        /// Method <c>getSchema</c> gets schema from readFile() method
        /// </summary>
        /// <returns>
        /// string schema from config
        /// </returns>
        public static string getSchema()
        {
            return readFile()["schema"];
        }
        /// <summary>
        /// Method <c>getUrl</c> gets url from readFile() method
        /// </summary>
        /// <returns>
        /// string url from config
        /// </returns>
        public static string getUrl()
        {
            return readFile()["scrape_url"];
        }
    }
}
