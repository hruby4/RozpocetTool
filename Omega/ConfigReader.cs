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
        
        public static Dictionary<string, string> readFile() {
            try {
                string json = System.IO.File.ReadAllText(@"../../config.conf");
                return JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            }

            catch {
                return null;
            }
            
        }
        public static string getAddress() {
            return readFile()["address"];
        }

        public static UInt32 getPort()
        {
            return System.Convert.ToUInt32(readFile()["port"]);
        }

        public static string getUser()
        {
            return readFile()["user"];
        }

        public static string getPassword()
        {
            return readFile()["password"];
        }

        public static string getSchema()
        {
            return readFile()["schema"];
        }

        public static string getUrl()
        {
            return readFile()["scrape_url"];
        }
    }
}
