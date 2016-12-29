using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BrightLocal
{
    public class LocationService: BrightLocalService
    {
        public LocationService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalLocation Create(LocationOptions createOptions)
        {
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(Urls.Locations, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLocation>(success.Content);
        }

        public virtual BrightLocalLocation Update(LocationOptions createOptions)
        {
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Put(Urls.Locations, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLocation>(success.Content);
        }

        public virtual BrightLocalLocation Delete(int locationId)
        {
            var parameters = new Parameters.requestParameters();            
            var success = request.Delete(Urls.Locations + "/" + locationId, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLocation>(success.Content);
        }

        public virtual BrightLocalLocation Get(int locationId)
        {
            var url = string.Format(Urls.Locations + "/{0}", locationId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalLocation>(success.Content);
        }

        public virtual List<BrightLocalLocation> Search(string query)
        {
            var url = string.Format(Urls.Locations + "/search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var results = request.Get(url, parameters, this.api_key, this.api_secret);

            List<BrightLocalLocation> locations = new List<BrightLocalLocation>();
            foreach (var location in results.Content[0].ToString())
            {
                locations.Add(JsonConvert.DeserializeObject<BrightLocalLocation>(location.ToString()));
            }
            return locations;
        }
    }
}
