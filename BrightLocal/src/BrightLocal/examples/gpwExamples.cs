using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.examples
{
    public class gpwExamples
    {
        public static IRestResponse addReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report_name", "Sample SEO Check-Up Report");
            parameters.Add("business_names", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("day_of_month", "2");
            parameters.Add("report_type", "with");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state_code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("phone_number", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");

            var success = request.Post("v4/gpw/add", parameters);

            return success;
        }

        public static IRestResponse updateReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();
            parameters.Add("report_name", "Sample SEO Check-Up Report");
            parameters.Add("business_names", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("day_of_month", "2");
            parameters.Add("report_type", "with");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state_code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("phone_number", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");

            var success = request.Put("v4/gpw/" + reportId + "", parameters);

            return success;
        }

        public static IRestResponse getReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();

            var results = request.Get("v4/gpw/" + reportId + "", parameters);

            return results;
        }

        public static IRestResponse deleteReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();

            var success = request.Delete("v4/gpw/" + reportId + "", parameters);

            return success;
        }

        public static IRestResponse getAllReports()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();

            var results = request.Get("v4/gpw", parameters);

            return results;
        }

        public static IRestResponse runReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-id", "1");

            var success = request.Put("v4/gpw/run", parameters);

            return success;
        }

        public static IRestResponse getReportResults()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();            

            var results = request.Get("v4/gpw/" + reportId + "/results", parameters);

            return results;
        }
    }
}
