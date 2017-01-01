using Newtonsoft.Json;

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
        [JsonProperty("reference-number")]
        public string referenceNumber { get; set; }
    }
}
