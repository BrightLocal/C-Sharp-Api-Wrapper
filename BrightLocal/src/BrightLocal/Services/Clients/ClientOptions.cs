using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class ClientOptions
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("company-url")]
        public string companyUrl { get; set; }
        [JsonProperty("business-category-id")]
        public int businessCategoryId { get; set; }
    }
}
