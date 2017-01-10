using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    internal static class Urls
    {
        internal static string BaseUrl => "https://tools.brightlocal.com/seo-tools/api";
        internal static string Clients => "/v1/clients-and-locations/clients/";
        internal static string Locations => "/v1/clients-and-locations/locations/";
        internal static string Lsrc => "/v2/lsrc/";
        internal static string Lscu => "/v4/lscu/";
        internal static string CitationTracker => "/v2/ct/";
        internal static string CitationBurst => "/v2/cb/";

    }
}
