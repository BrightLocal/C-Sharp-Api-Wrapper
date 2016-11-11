using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.examples
{
    public class ctExamples
    {
        public static IRestResponse addReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-name", "Sample Citation Tracking Report");
            parameters.Add("business-name", "Le Bernardin");
            parameters.Add("business-location", "NY, New York");
            parameters.Add("phone", "+1 212-554-1515");
            parameters.Add("website", "le-bernardin.com");
            parameters.Add("business-type", "Restaurant");            
            parameters.Add("state-code", "NY");           

            var success = request.Post("v2/ct/add", parameters);

            return success;
        }

        public static IRestResponse updateReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-name", "Sample Citation Tracking Report");
            parameters.Add("business-name", "Le Bernardin");
            parameters.Add("business-location", "NY, New York");
            parameters.Add("phone", "+1 212-554-1515");
            parameters.Add("website", "le-bernardin.com");
            parameters.Add("business-type", "Restaurant");
            parameters.Add("state-code", "NY");

            var success = request.Post("v2/ct/update", parameters);

            return success;
        }

        public static IRestResponse getReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "682");

            var results = request.Get("v2/ct/get", parameters);

            return results;
        }

        public static IRestResponse runReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "682");

            var success = request.Post("v2/ct/run", parameters);

            return success;
        }

        public static IRestResponse deleteReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "682");

            var success = request.Post("v2/ct/delete", parameters);

            return success;
        }

        public static IRestResponse getAllReports()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();

            var results = request.Get("v2/ct/get-all", parameters);

            return results;
        }

        public static IRestResponse getReportResults()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "2457");

            var results = request.Get("v2/ct/get-results", parameters);

            return results;
        }

    }
}
