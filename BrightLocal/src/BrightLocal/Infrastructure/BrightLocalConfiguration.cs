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
            if (string.IsNullOrEmpty(api_key))
            {
                api_key = ConfigurationManager.AppSettings["BrightLocalApiKey"];
            }                
            return api_key;       
        }

        public static string GetApiSecret()
        {
            if (string.IsNullOrEmpty(api_secret))
            {
                api_secret = ConfigurationManager.AppSettings["BrightLocalApiSecret"];
            }           
            return api_secret;
        }

        public static void SetApiCreds(string newApiKey, string newApiSecret)
        {
            api_key = newApiKey;
            api_secret = newApiSecret;
        }
    }
}
