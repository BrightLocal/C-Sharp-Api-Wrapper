using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace BrightLocal
{
    public static class BrightLocalConfiguration
    {
        // Decalre Variables
        private static string api_key;
        private static string api_secret;

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(api_key))
            {
                api_key = ConfigurationManager.AppSettings["BrightLocalApiKey"];
            }                
            return api_key;       
        }

        internal static string GetApiSecret()
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
