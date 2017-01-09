using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace BrightLocal
{
    public class LscuService: BrightLocalService
    {
        public LscuService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalSuccess Create(LscuOptions createOptions)
        {
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Update(UpdateLscuOptions updateOptions)
        {
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalLscuReport Get(int reportId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Get(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLscuReport>(success.Content);
        }

        // returns success or failed as a string message
        public virtual string Run(int reportId)
        {
            string response;
            var url = string.Format(Urls.Lscu + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(Urls.Lscu, parameters, this.api_key, this.api_secret);
            if(JsonConvert.DeserializeObject<bool>(success.Content))
            {
                response = "Success, your report is running";
            }
            else
            {
                response = "Falied, " + success.Content;
            }

            return response;  
        }

        // returns success or failed as a string message
        public virtual string Delete(int reportId)
        {
            string response;
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Delete(Urls.Lscu, parameters, this.api_key, this.api_secret);
            if (JsonConvert.DeserializeObject<bool>(success.Content))
            {
                response = "Success, your report has been deleted";
            }
            else
            {
                response = "Falied, " + success.Content;
            }

            return response;
        }

        public virtual BrightLocalLscuSearch Search(string query)
        {
            var url = string.Format(Urls.Lscu + "{0}", "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var success = request.Get(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLscuSearch>(success.Content);
        }
    }
}
