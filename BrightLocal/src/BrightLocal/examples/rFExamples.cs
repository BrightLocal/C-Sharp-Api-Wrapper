using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.examples
{
    public class rFExamples
    {
        public static IRestResponse addReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("report-name", "Sample Citation Tracking Report");
            parameters.Add("business-name", "Le Bernardin");            
            parameters.Add("contact-telephone", "+1 212-554-1515");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");            
            parameters.Add("postcode", "10019");
            parameters.Add("country", "USA"); // USA only

            var success = request.Post("v4/rf/add", parameters);

            return success;
        }

        public static IRestResponse updateReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();
            parameters.Add("business-name", "Le Bernardin");
            parameters.Add("contact-telephone", "+1 212-554-1515");

            var success = request.Put("v4/rf/" + reportId + "", parameters);

            return success;
        }

        public static IRestResponse getReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();

            var results = request.Get("v4/rf/" + reportId + "", parameters);

            return results;
        }

        public static IRestResponse deleteReport()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 1;
            var parameters = new api.Parameters();

            var success = request.Delete("v4/rf/" + reportId + "", parameters);

            return success;
        }

        public static IRestResponse getAllReports()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
            
            var parameters = new api.Parameters();

            var results = request.Get("v4/rf", parameters);

            return results;
        }

        public static IRestResponse searchReports()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("q", "Le Bernardin");            

            var results = request.Get("v4/rf/search", parameters);

            return results;
        }

        public static IRestResponse getReviews()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 141;
            var parameters = new api.Parameters();

            var results = request.Get("v4/rf/" + reportId + "/reviews", parameters);

            return results;
        }

        public static IRestResponse getReviewsCount()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 141;
            var parameters = new api.Parameters();

            var count = request.Get("v4/rf/" + reportId + "/reviews/count", parameters);

            return count;
        }

        public static IRestResponse getReviewsGrowth()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 141;
            var parameters = new api.Parameters();

            var growth = request.Get("v4/rf/" + reportId + "/reviews/growth", parameters);

            return growth;
        }

        public static IRestResponse getReviewsDirectories()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 141;
            var parameters = new api.Parameters();

            var directories = request.Get("v4/rf/" + reportId + "/directories", parameters);

            return directories;
        }

        public static IRestResponse getReviewsDirectoriesStats()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 141;
            var parameters = new api.Parameters();

            var stats = request.Get("v4/rf/" + reportId + "/directories/stats", parameters);

            return stats;
        }

        public static IRestResponse getReviewsStarCounts()
        {
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var reportId = 141;
            var parameters = new api.Parameters();

            var stars = request.Get("v4/rf/" + reportId + "/stars/count", parameters);

            return stars;
        }
    }
}
