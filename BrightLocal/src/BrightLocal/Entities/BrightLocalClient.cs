using Newtonsoft.Json;

namespace BrightLocal
{
    public class BrightLocalClient
    {
        [JsonProperty("client-id")]
        public int clientId { get; set; }        
        [JsonProperty("company-name")]
        public string companyName { get; set; }
        [JsonProperty("company-url")]
        public string companyUrl { get; set; }
        [JsonProperty("business-category-id")]
        public int? businessCategoryId { get; set; }
        [JsonProperty("reference-number")]
        public string referenceNumber { get; set; }
    }
}
