using BrightLocal.Entities;
using BrightLocal.Infrastructure;
using BrightLocal.Services.Clients;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Services
{
    public class ClientService : BrightLocalService
    {
        public ClientService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();
        public virtual BrightLocalClient Create(ClientOptions createOptions)
        {
           var parameters = Parameters.convertListToParameters(createOptions);
           var success =  request.Post(Urls.Clients, parameters);
           return JsonConvert.DeserializeObject<BrightLocalClient>(success.Content);
        }

        public virtual BrightLocalClient Update(UpdateClientOptions updateOptions)
        {
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(Urls.Clients, parameters);
            return JsonConvert.DeserializeObject<BrightLocalClient>(success.Content);
        }
    }
}
