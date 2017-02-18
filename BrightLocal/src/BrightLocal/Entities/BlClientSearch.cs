using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlClientSearch
    {
        [JsonProperty("success")]
        public bool success { get; set; }
        [JsonProperty("clients")]
        public List<Client> clients { get; set; }
    }

    public class Client
    {
        [JsonProperty("client-id")]
        public int clientId { get; set; }
        [JsonProperty("company-name")]
        public string companyName { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("client-reference")]
        public string clientReference { get; set; }
        [JsonProperty("business-category-id")]
        public int businessCategoryId { get; set; }
    }
}
