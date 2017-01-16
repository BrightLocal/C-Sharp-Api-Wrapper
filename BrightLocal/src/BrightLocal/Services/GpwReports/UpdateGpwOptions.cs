using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class UpdateGpwOptions
    {
        [JsonProperty("report-ID")]
        public string reportId { get; set; }
        [JsonProperty("report_name")]
        public string reportName { get; set; }
        [JsonProperty("location_id")]
        public int locationId { get; set; }
        [JsonProperty("white_label_profile_id")]
        public int whiteLabelProfileId { get; set; }
        [JsonProperty("business_names")]
        public string businessNames { get; set; }
        [JsonProperty("schedule")]
        public string schedule { get; set; }
        [JsonProperty("day_of_month")]
        public string dayOfMonth { get; set; }
        [JsonProperty("report_type")]
        public string reportType { get; set; }
        [JsonProperty("address1")]
        public string address1 { get; set; }
        [JsonProperty("address2")]
        public string address2 { get; set; }
        [JsonProperty("profile_url")]
        public string profileUrl { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("state_code")]
        public string stateCode { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("phone_number")]
        public string phoneNumber { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("search_terms")]
        public List<string> searchTerms { get; set; }
        [JsonProperty("notify")]
        public string notify { get; set; }
        [JsonProperty("email-addresses")]
        public List<string> emailAddresses { get; set; }
        [JsonProperty("google_location")]
        public string googleLocation { get; set; }
        [JsonProperty("is_public")]
        public string isPublic { get; set; }
        [JsonProperty("run")]
        public string run { get; set; }
    }
}
