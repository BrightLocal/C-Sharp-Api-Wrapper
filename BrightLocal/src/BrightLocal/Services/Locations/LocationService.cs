using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace BrightLocal
{
    public class LocationService: BlService
    {
        public LocationService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(LocationOptions createOptions)
        {
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(Urls.Locations, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
            
        }

        public virtual BlSuccess Update(UpdateLocationOptions updateOptions)
        {
            var url = string.Format(Urls.Locations + "{0}", updateOptions.locationId);
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Delete(int locationId)
        {
            var url = string.Format(Urls.Locations + "{0}", locationId);
            var parameters = new Parameters.requestParameters();            
            var success = request.Delete(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlLocation Get(int locationId)
        {
            var url = string.Format(Urls.Locations + "{0}", locationId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            JObject o = JObject.Parse(success.Content);
            return JsonConvert.DeserializeObject<BlLocation>(o.SelectToken("location").ToString());            
        }

        public virtual BlLocationSearch Search(string query)
        {
            var url = string.Format(Urls.Locations + "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var results = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlLocationSearch>(results.Content);
        }
    }
}
