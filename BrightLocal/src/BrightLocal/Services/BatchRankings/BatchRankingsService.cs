using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BatchRankingsService : BrightLocalService
    {
        public BatchRankingsService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalBatchRequestor batchRequest = new BrightLocalBatchRequestor();

        BrightLocalRequestor request = new BrightLocalRequestor();
        public virtual BlBatchSuccess Search(RankingsSearchOptions searchOptions)
        {
            BlBatchSuccess ids = new BlBatchSuccess();
            var batchId = batchRequest.Create(this.api_key);
            var url = string.Format(Urls.Rankings + "{0}", "search");
            foreach(var search in searchOptions.searches)
            {
                var parameters = Parameters.convertListToParameters(search);
                parameters.Add("batch-id", batchId);
                var success = request.Post(url, parameters, this.api_key, this.api_secret);
                dynamic job = JsonConvert.DeserializeObject(success.Content);
                ids.jobids.Add("Job-Id", job["job-id"]);
            }

            var commit = batchRequest.Commit(batchId, this.api_key);
            dynamic obj = JsonConvert.DeserializeObject(commit.Content);
            if(obj.success == true)
            {
                ids.jobids.Add("success", true);
                ids.batchId = batchId;
            }
            else
            {
                throw new ApplicationException(obj);
            }
            return  ids;
        }

        public virtual BlSuccess GetSearchResults(int batchId)
        {            
            var results = batchRequest.GetResults(batchId, this.api_key);
            return JsonConvert.DeserializeObject<BlSuccess>(results.Content);
        }
    }
}
