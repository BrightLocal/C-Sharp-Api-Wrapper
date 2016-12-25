using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace BrightLocal.Infrastructure
{
    public class BrightLocalConfiguration
    {
        // Decalre Variables
        private static string api_key;
        private static string api_secret;

        public static string GetApiKey()
        {
            api_key = ConfigurationManager.AppSettings["BrightLocalApiKey"];
            return api_key;       
        }

        public static string GetApiSecret()
        {
            api_secret = ConfigurationManager.AppSettings["BrightLocalApiSecret"];
            return api_secret;
        }

        public static void SetApiCreds(string newApiKey, string newApiSecret)
        {
            api_key = newApiKey;
            api_secret = newApiSecret;
        }
    }
}
