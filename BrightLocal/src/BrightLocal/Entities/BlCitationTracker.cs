using Newtonsoft.Json;

namespace BrightLocal
{
    public class BlCitationTracker
    {
        [JsonProperty("report-id")]
        public int reportId { get; set; }
        [JsonProperty("location-id")]
        public int locationId { get; set; }
        [JsonProperty("report-name")]
        public string reportName { get; set; }
        [JsonProperty("business-name")]
        public string businessName { get; set; }
        [JsonProperty("business-location")]
        public string businessLocation { get; set; }
        [JsonProperty("old-business-name-1")]
        public string oldBusinessName1 { get; set; }
        [JsonProperty("old-business-name-2")]
        public string oldBusinessName2 { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("old-postcode-1")]
        public string oldPostcode1 { get; set; }
        [JsonProperty("old-postcode-2")]
        public string oldPostcode2 { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("phone")]
        public string phone { get; set; }
        [JsonProperty("website")]
        public string website { get; set; }
        [JsonProperty("business-type")]
        public string businessType { get; set; }
        [JsonProperty("state-code")]
        public string stateCode { get; set; }
        [JsonProperty("monthly-run")]
        public int monthlyRun { get; set; }
        [JsonProperty("weekly-run")]
        public int weeklyRun { get; set; }
        [JsonProperty("white-label-profile-id")]
        public int whiteLabelProfileId { get; set; }
        [JsonProperty("active-only")]
        public string activeOnly { get; set; }
        public string notify { get; set; }
        [JsonProperty("email-addresses")]
        public string emailAddresses { get; set; }
        [JsonProperty("is-public")]
        public string isPublic { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
    }
}
