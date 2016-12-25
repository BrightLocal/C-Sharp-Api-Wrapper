using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public abstract class BrightLocalService
    {
        // Decalre Variables
        private string api_key;
        private string api_secret;

        internal BrightLocalService(string key, string secret)
        {
            api_key = key;
            api_secret = secret;
        }
    }
}
