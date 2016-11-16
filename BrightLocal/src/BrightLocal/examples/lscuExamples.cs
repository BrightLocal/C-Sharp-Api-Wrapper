using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.examples
{
    public class lscuExamples
    {
        public static IRestResponse addReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-name", "Sample SEO Check-Up Report");
            parameters.Add("business-names", "['Le Bernardin']");
            parameters.Add("website-address", "le-bernardin.com");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state-code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("telephone", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("primary-business-location", "NY, New York");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");
          
            var success = request.Post("v4/lscu", parameters);

            return success;
        }

        public static IRestResponse updateReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "1");        
            parameters.Add("postcode", "10019");
            parameters.Add("telephone", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("primary-business-location", "NY, New York");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");

            var success = request.Put("v4/lscu", parameters);

            return success;
        }

        public static IRestResponse getReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "860");

            var results = request.Get("v4/lscu", parameters);

            return results;
        }

        public static IRestResponse runReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "860");

            var success = request.Put("v4/lscu/run", parameters);

            return success;
        }

        public static IRestResponse deleteReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "860");

            var success = request.Delete("v4/lscu", parameters);

            return success;
        }

        public static IRestResponse searchReports()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("q", "Bodega Wine Bar");

            var results = request.Get("v4/lscu/search", parameters);

            return results;
        }
    }
}
