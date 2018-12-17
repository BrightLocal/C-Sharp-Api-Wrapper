using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Batch_Methods
{
    public class rankingsExamples
    {
        public static BlSuccess Create()
        {                           
            RankingsSearchOptions search = new RankingsSearchOptions();
            search.searches.Add(new SearchOptions()
            {
                searchEngine = "google",
                country = "USA",
                googleLocation = "New York, NY",
                searchTerm = "restaurant new york",
                urls = JsonConvert.SerializeObject(new List<string>() { "le-bernardin.com" }),
                businessNames = JsonConvert.SerializeObject(new List<string> { "Le Bernardin" })
            });
            search.searches.Add(new SearchOptions()
            {
                searchEngine = "yahoo",
                country = "USA",
                googleLocation = "New York, NY",
                searchTerm = "restaurant new york",
                urls = JsonConvert.SerializeObject(new List<string>() { "le-bernardin.com" }),
                businessNames = JsonConvert.SerializeObject(new List<string> { "Le Bernardin" })
            });

            var batchRankingService = new BatchRankingsService();
            BlBatchSuccess newBatchRankings = batchRankingService.Search(search);

            var rankingsResults = batchRankingService.GetSearchResults(newBatchRankings.batchId);

            //if (rankingsResults.success)
            //{
            //    while (rankingResults.status != "Stopped" || rankingResults.status != "Finished")
            //    {
            //        Thread.Sleep(10000);
                    
            //        rankingsResults = batchRankingService.GetSearchResults(newBatchRankings.batchId);
            //    }
            //    return rankingsResults;
            //}
            //else
            //{
            //    const string message = "Error Retrieving batch results ";
            //    var batchException = new ApplicationException(message + rankingResults.errors, results.ErrorException);
            //    throw batchException;
            //}

            return rankingsResults;
        }
    }
}
