using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BrightLocal
{
    public class ClientService : BrightLocalService
    {
        public ClientService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }   

       
        BrightLocalRequestor request = new BrightLocalRequestor();      

        public virtual BrightLocalClient Create(ClientOptions createOptions)
        {
           var parameters = Parameters.convertListToParameters(createOptions);
           var success =  request.Post(Urls.Clients, parameters, this.api_key, this.api_secret);
           return JsonConvert.DeserializeObject<BrightLocalClient>(success.Content);
        }

        public virtual BrightLocalClient Update(UpdateClientOptions updateOptions)
        {
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(Urls.Clients, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalClient>(success.Content);
        }

        public virtual BrightLocalClient Delete(int clientId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("client-id", clientId);
            var success = request.Delete(Urls.Clients, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalClient>(success.Content);
        }

        public virtual BrightLocalClient Get(int clientId)
        {
            var url = string.Format(Urls.Clients + "{0}", clientId);
            var parameters = new Parameters.requestParameters();            
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalClient>(success.Content);
        }

        public virtual List<BrightLocalClient> Search(string query)
        {
            var url = string.Format(Urls.Clients + "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var results = request.Get(url, parameters, this.api_key, this.api_secret);

            List<BrightLocalClient> clients = new List<BrightLocalClient>();
            foreach (var client in results.Content[0].ToString())
            {
               clients.Add(JsonConvert.DeserializeObject<BrightLocalClient>(client.ToString()));
            }
            return clients;
        }
    }
}
