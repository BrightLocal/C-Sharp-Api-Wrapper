using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Infrastructure
{
    internal static class Urls
    {
        internal static string BaseUrl => "https://tools.brightlocal.com/seo-tools/api";
        internal static string Clients => BaseUrl + "/v1/clients-and-locations/clients/";
    }
}
