using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Routing;

namespace BrightLocal.Batches.examples
{
    public class rankingsExamples
    {
        public static IRestResponse search()
        {

            List<RankingsSearch> searches = new List<RankingsSearch>();
            searches.Add(new RankingsSearch()
            {
                search_engine = "google",
                country = "USA",
                google_location = "New York, NY",
                search_term = "restaurant new york",
                urls = new List<string>() { "le-bernardin.com" },
                business_names = new List<string>() { "Le Bernardin" }
            });
            searches.Add(new RankingsSearch()
            {
                search_engine = "yahoo",
                country = "USA",
                google_location = "New York, NY",
                search_term = "restaurant new york",
                urls = new List<string>() { "le-bernardin.com" },
                business_names = new List<string>() { "Le Bernardin" }
            });


            api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
            batchApi batchRequest = new batchApi(Api);

            // Create a new batch
            int batchId = batchRequest.Create();
            var parameters = new api.Parameters();
            
            // Add jobs to batch
            foreach (var item in searches)
            {
                // Convert the searches list into parameters for the web requestt
                parameters = batchRequest.convertListToParameters(item);
                parameters.Add("batch-id", batchId);

                var jobId = Api.Post("/v4/rankings/search", parameters);

                if (jobId.ResponseStatus == ResponseStatus.Completed)
                {
                    dynamic job = JsonConvert.DeserializeObject(jobId.Content);
                    if (job.success != "true")
                    {
                        string message = "Error adding job";
                        var batchException = new ApplicationException(message + job.errors, job.ErrorException);
                        throw batchException;
                    }
                }
                else
                {
                    throw new ApplicationException(jobId.ErrorMessage);
                }
            }
            // Commit the batch, resturns true or false
            bool commit = batchRequest.Commit(batchId);

            // Poll for results. In a real world example you should do this in a backgroud process, such as HangFire,  or use the Task Parallel Library to create a BackGroundWorker Task.
            // It is bad practice to use Thread.Sleep(). This is only for the example and will actually freeze the UI until the while loop is finished. 

            var results = batchRequest.GetResults(batchId);
            dynamic rankingResults = JsonConvert.DeserializeObject(results.Content);

            if (rankingResults.success == "true")
            {
                while (rankingResults.status != "Stopped" || rankingResults.status != "Finished")
                {
                    Thread.Sleep(10000);
                    results = batchRequest.GetResults(batchId);
                    rankingResults = JsonConvert.DeserializeObject(results.Content);
                }
                return rankingResults;
            }
            else
            {
                const string message = "Error Retrieving batch results ";
                var batchException = new ApplicationException(message, results.ErrorException);
                throw batchException;
            }
        }

        public static IRestResponse bulkSearch()
        {

            List<string> searches = new List<string>(
                new string[] {
                    "restaurant new york'",
                    "restaurant manhattan",
                    "restaurant 10019"
                });

            api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
            batchApi batchRequest = new batchApi(Api);

            // Create a new batch
            int batchId = batchRequest.Create();
            var parameters = new api.Parameters();
            
            parameters.Add("batch-id", batchId);
            parameters.Add("search-engine", "google");
            parameters.Add("country", "USA");
            parameters.Add("telephone", "+1 212-554-1515");
            parameters.Add("google-location", "New York, NY");
            parameters.Add("search-terms", searches);
            parameters.Add("urls", "['le-bernardin.com']");
            parameters.Add("business-names", "['Le Bernardin']");
            var jobId = Api.Post("/v4/rankings/bulk-search", parameters);

                if (jobId.ResponseStatus == ResponseStatus.Completed)
                {
                    dynamic job = JsonConvert.DeserializeObject(jobId.Content);
                    if (job.success != "true")
                    {
                        string message = "Error adding job";
                        var batchException = new ApplicationException(message + job.errors, job.ErrorException);
                        throw batchException;
                    }
                }
                else
                {
                    throw new ApplicationException(jobId.ErrorMessage);
                }
            
            // Commit the batch, resturns true or false
            bool commit = batchRequest.Commit(batchId);

            // Poll for results. In a real world example you should do this in a backgroud process, such as HangFire,  or use the Task Parallel Library to create a BackGroundWorker Task.
            // It is bad practice to use Thread.Sleep(). This is only for the example and will actually freeze the UI until the while loop is finished. 

            var results = batchRequest.GetResults(batchId);
            dynamic rankingResults = JsonConvert.DeserializeObject(results.Content);

            if (rankingResults.success == "true")
            {
                while (rankingResults.status != "Stopped" || rankingResults.status != "Finished")
                {
                    Thread.Sleep(10000);
                    results = batchRequest.GetResults(batchId);
                    rankingResults = JsonConvert.DeserializeObject(results.Content);
                }
                return rankingResults;
            }
            else
            {
                const string message = "Error Retrieving batch results ";
                var batchException = new ApplicationException(message, results.ErrorException);
                throw batchException;
            }
        }
    }
}
