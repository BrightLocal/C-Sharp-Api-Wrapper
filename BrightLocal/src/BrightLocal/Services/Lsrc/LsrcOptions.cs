using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class LsrcOptions
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("schedule")]
        public string schedule { get; set; }
        [JsonProperty("day-of-week")]
        public string dayOfWeek { get; set; }
        [JsonProperty("day-of-month")]
        public int dayOfMonth { get; set; }
        [JsonProperty("location-id")]
        public int locationId { get; set; }
        [JsonProperty("white-label-profile-id")]
        public int whiteLabelProfileId { get; set; }
        [JsonProperty("tags")]
        public string tags { get; set; }
        [JsonProperty("search-terms")]
        public string searchTerms { get; set; }
        [JsonProperty("website-addresses")]
        public List<string> websiteAddresses { get; set; }
        [JsonProperty("website-address")]
        public string websiteAddress { get; set; }
        [JsonProperty("website-address-2")]
        public string websiteAddress2 { get; set; }
        [JsonProperty("website-address-3")]
        public string websiteAddress3 { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("google-location")]
        public string googleLocation { get; set; }
        [JsonProperty("bing-location")]
        public string bingLocation { get; set; }
        [JsonProperty("business-names")]
        public string businessNames { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("telephone")]
        public string telephone { get; set; }
        [JsonProperty("search-engines")]
        public string searchEngines { get; set; }
        [JsonProperty("include-local-directory-results")]
        public string includeLocalDirectoryResults { get; set; }
        [JsonProperty("notify")]
        public string notify { get; set; }
        [JsonProperty("email-addresses")]
        public string emailAddresses { get; set; }
        [JsonProperty("is-public")]
        public string isPublic { get; set; }
    }
}

