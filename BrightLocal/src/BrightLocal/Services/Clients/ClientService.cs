using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace BrightLocal
{
    public class ClientService : BlService
    {
        public ClientService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }   

       
        BlRequestor request = new BlRequestor();      

        public virtual BlSuccess Create(Client create)
        {
           var parameters = Parameters.convertListToParameters(create);
           var success =  request.Post(Urls.Clients, parameters, this.api_key, this.api_secret);
           return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateClient update)
        {
            var parameters = Parameters.convertListToParameters(update);
            var success = request.Put(Urls.Clients, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Delete(int clientId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("client-id", clientId);
            var success = request.Delete(Urls.Clients, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlClient Get(int clientId)
        {
            var url = string.Format(Urls.Clients + "{0}", clientId);
            var parameters = new Parameters.requestParameters();            
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            JObject o = JObject.Parse(success.Content);            
            return JsonConvert.DeserializeObject<BlClient>(o.SelectToken("client").ToString());
        }

        public virtual BlClientSearch Search(string query)
        {
            var url = string.Format(Urls.Clients + "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var results = request.Get(url, parameters, this.api_key, this.api_secret);

            return JsonConvert.DeserializeObject<BlClientSearch>(results.Content);          
        }
    }
}
