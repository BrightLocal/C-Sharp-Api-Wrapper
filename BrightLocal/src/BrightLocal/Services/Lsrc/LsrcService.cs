using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace BrightLocal
{
    public class LsrcService: BlService
    {
        public LsrcService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(Lsrc create)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "add");
            create.searchTerms = Parameters.convertToNewline(create.searchTerms);
            if(create.businessNames != null)
            {
                create.businessNames = Parameters.convertToNewline(create.businessNames);
            }
            if (create.emailAddresses != null)
            {
                create.emailAddresses = Parameters.convertToNewline(create.emailAddresses);
            }
            var parameters = Parameters.convertListToParameters(create);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateLsrc update)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "update");
            if (update.searchTerms != null)
            {
                update.searchTerms = Parameters.convertToNewline(update.searchTerms);
            }
            if (update.businessNames != null)
            {
                update.businessNames = Parameters.convertToNewline(update.businessNames);
            }
            if (update.emailAddresses != null)
            {
                update.emailAddresses = Parameters.convertToNewline(update.emailAddresses);
            }
            var parameters = Parameters.convertListToParameters(update);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Delete(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "delete");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        //method overlaod for supplying the location-id parameter
        public virtual BlGetAllResults GetAll(int locationId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();           
            parameters.Add("location-id", locationId);
            
            var results = request.Get(url, parameters, this.api_key, this.api_secret);
            
            return JsonConvert.DeserializeObject<BlGetAllResults>(results.Content);
            
        }

        public virtual BlGetAllResults GetAll()
        {
            var url = string.Format(Urls.Lsrc + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            
            var results = request.Get(url, parameters, this.api_key, this.api_secret);

            return JsonConvert.DeserializeObject<BlGetAllResults>(results.Content);
        }

        public virtual BlLsrcReport Get(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlLsrcReport>(success.Content);
        }

        public virtual BlSuccess Run(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlLsrcHistory GetHistory(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "history/get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var results = request.Post(url, parameters, this.api_key, this.api_secret);

            return JsonConvert.DeserializeObject<BlLsrcHistory>(results.Content);           
        }

        public virtual BlLsrcReportResults GetResults(GetResultsLsrc lsrc)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "results/get");
            var parameters = Parameters.convertListToParameters(lsrc);
           
            var results = request.Get(url, parameters, this.api_key, this.api_secret);
            var report = JsonConvert.DeserializeObject<BlLsrcReportResults>(results.Content);
            return report;
        }
    }
}
