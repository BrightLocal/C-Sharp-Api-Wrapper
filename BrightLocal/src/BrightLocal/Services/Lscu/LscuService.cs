using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace BrightLocal
{
    public class LscuService: BlService
    {
        public LscuService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(Lscu create)
        {
            var parameters = Parameters.convertListToParameters(create);
            var success = request.Post(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateLscu update)
        {
            var parameters = Parameters.convertListToParameters(update);
            var success = request.Put(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlLscuReport Get(int reportId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Get(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlLscuReport>(success.Content);
        }

        // returns success or failed as a string message
        public virtual BlSuccess Run(int reportId)
        {
            var url = string.Format(Urls.Lscu + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);

            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        // returns success or failed as a string message
        public virtual BlSuccess Delete(int reportId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Delete(Urls.Lscu, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlLscuSearch Search(string query)
        {
            var url = string.Format(Urls.Lscu + "{0}", "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlLscuSearch>(success.Content);
        }
    }
}
