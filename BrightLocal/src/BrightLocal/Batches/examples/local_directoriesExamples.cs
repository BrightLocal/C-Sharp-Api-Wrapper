using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BrightLocal.Batches.examples
{
    public class local_directoriesExamples
    {
        public static IRestResponse FetchProfileUrl()
        {
            api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
            batchApi batchRequest = new batchApi(Api);

            // Create a new batch
            int batchId = batchRequest.Create();
            var parameters = new api.Parameters();
            parameters.Add("batch-id", batchId);
            parameters.Add("business-names", "La Bernardin\nBernardin Cafe\nBernardin restaraunt");
            parameters.Add("country", "USA");
            parameters.Add("city", "New York");
            parameters.Add("postcode", "10019");
            parameters.Add("local-directory", "google");


            var jobId = Api.Post("/v4/ld/fetch-profile-url", parameters);

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
                return results;
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
