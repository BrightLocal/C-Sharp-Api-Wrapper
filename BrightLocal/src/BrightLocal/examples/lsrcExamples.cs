using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.examples
{
    public class lsrcExamples
    {
        public static IRestResponse addReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("name", "Le Bernardin");            
            parameters.Add("schedule", "Adhoc");
            parameters.Add("search-terms", "Restaurant\nfood+nyc\ndelivery+midtown+manhattan");
            parameters.Add("website-addresses", JsonConvert.SerializeObject("['le-bernardin.com', 'le-bernardin2.com']"));
            parameters.Add("search-engines", "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local");
            var success = request.Post("v2/lsrc/add", parameters);

            return success;
        }

        public static IRestResponse updateReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("campaign-id", "9907");
            parameters.Add("name", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("search-terms", "Restaurant\nfood+nyc\ndelivery+midtown+manhattan");
            parameters.Add("website-addresses", JsonConvert.SerializeObject("['le-bernardin.com', 'le-bernardin2.com']"));
            parameters.Add("search-engines", "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local");
            var success = request.Post("v2/lsrc/add", parameters);

            return success;
        }

        public static IRestResponse deleteReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("campaign-id", "9907");            
            var success = request.Delete("v2/lsrc/delete", parameters);

            return success;
        }

        public static IRestResponse getAllReports()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();            
            var results = request.Get("v2/lsrc/get-all", parameters);

            return results;
        }

        public static IRestResponse getReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("campaign-id", "50");

            var results = request.Get("v2/lsrc/get", parameters);

            return results;
        }

        public static IRestResponse runReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("campaign-id", "50");

            var success = request.Post("v2/lsrc/run", parameters);

            return success;
        }

        public static IRestResponse getReportHistory()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("campaign-id", "50");

            var results = request.Get("/v2/lsrc/history/get", parameters);

            return results;
        }

        public static IRestResponse getReportResults()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("campaign-id", "9636");

            var results = request.Get("v2/lsrc/results/get", parameters);

            return results;
        }
    }
}
