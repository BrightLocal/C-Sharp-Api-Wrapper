using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalLscu
    {
        [JsonProperty("report-id")]
        public string reportId { get; set; }
        [JsonProperty("report-name")]
        public string reportName { get; set; }
        [JsonProperty("location-id")]
        public int locationId { get; set; }
        [JsonProperty("white-label-profile-id")]
        public int whiteLabelProfileId { get; set; }
        [JsonProperty("business-names")]
        public List<string> businessNames { get; set; }
        [JsonProperty("website-address")]
        public string websiteAddress { get; set; }
        [JsonProperty("address1")]
        public string address1 { get; set; }
        [JsonProperty("address2")]
        public string address2 { get; set; }
        [JsonProperty("area")]
        public string area { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("state-code")]
        public string stateCode { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("telephone")]
        public string telephone { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("business-category")]
        public string businessCategory { get; set; }
        [JsonProperty("primary-business-location")]
        public string primaryBusinessLocation { get; set; }
        [JsonProperty("search-terms")]
        public List<string> searchTerms { get; set; }
        [JsonProperty("google-location")]
        public string googleLocation { get; set; }
        [JsonProperty("bing-location")]
        public string bingLocation { get; set; }
        [JsonProperty("notify")]
        public string notify { get; set; }
        [JsonProperty("email-addresses")]
        public string emailAddresses { get; set; }
        [JsonProperty("facebook-url")]
        public string facebookUrl { get; set; }
        [JsonProperty("twitter-url")]
        public string twitterUrl { get; set; }
        [JsonProperty("is-public")]
        public string isPublic { get; set; }
        [JsonProperty("local-directory-urls")]
        public LocalDirectoryUrls localDirectoryUrls { get; set; }
        [JsonProperty("run-report")]
        public string runReport { get; set; }
    }
}
