using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace BrightLocal
{
    public class LsrcService: BrightLocalService
    {
        public LsrcService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalSuccess Create(LsrcOptions createOptions)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "add");
            createOptions.searchTerms = Parameters.convertToNewline(createOptions.searchTerms);
            if(createOptions.businessNames != null)
            {
                createOptions.businessNames = Parameters.convertToNewline(createOptions.businessNames);
            }
            if (createOptions.emailAddresses != null)
            {
                createOptions.emailAddresses = Parameters.convertToNewline(createOptions.emailAddresses);
            }
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Update(UpdateLsrcOptions updateOptions)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "update");
            if (updateOptions.searchTerms != null)
            {
                updateOptions.searchTerms = Parameters.convertToNewline(updateOptions.searchTerms);
            }
            if (updateOptions.businessNames != null)
            {
                updateOptions.businessNames = Parameters.convertToNewline(updateOptions.businessNames);
            }
            if (updateOptions.emailAddresses != null)
            {
                updateOptions.emailAddresses = Parameters.convertToNewline(updateOptions.emailAddresses);
            }
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Delete(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "delete");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        //method overlaod for supplying the location-id parameter
        public virtual BrightLocalGetAllResults GetAll(int locationId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();           
            parameters.Add("location-id", locationId);
            
            var results = request.Get(url, parameters, this.api_key, this.api_secret);
            
            return JsonConvert.DeserializeObject<BrightLocalGetAllResults>(results.Content);
            
        }

        public virtual BrightLocalGetAllResults GetAll()
        {
            var url = string.Format(Urls.Lsrc + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            
            var results = request.Get(url, parameters, this.api_key, this.api_secret);

            return JsonConvert.DeserializeObject<BrightLocalGetAllResults>(results.Content);
        }

        public virtual BrightLocalLsrcReport Get(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLsrcReport>(success.Content);
        }

        public virtual BrightLocalLsrc Run(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLsrc>(success.Content);
        }

        public virtual BrightLocalLsrcHistory GetHistory(int campaignId)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "history/get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var results = request.Post(url, parameters, this.api_key, this.api_secret);

            return JsonConvert.DeserializeObject<BrightLocalLsrcHistory>(results.Content);           
        }

        public virtual Object GetResults(GetResultsLsrcOptions lsrcOptions)
        {
            var url = string.Format(Urls.Lsrc + "{0}", "results/get");
            var parameters = Parameters.convertListToParameters(lsrcOptions);
           
            var results = request.Get(url, parameters, this.api_key, this.api_secret);
            var report = JsonConvert.DeserializeObject(results.Content);
            return report;
        }
    }
}
