using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class UpdateReviewFlowOptions
    {
        [JsonProperty("report-id")]
        public string reportId { get; set; }
        [JsonProperty("report-name")]
        public string reportName { get; set; }
        [JsonProperty("location-id")]
        public int locationId { get; set; }
        [JsonProperty("white-label-profile-id")]
        public int whiteLabelProfileId { get; set; }
        [JsonProperty("business-name")]
        public string businessName { get; set; }
        [JsonProperty("contact-telephone")]
        public string contactTelephone { get; set; }
        [JsonProperty("address1")]
        public string address1 { get; set; }
        [JsonProperty("address2")]
        public string address2 { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("schedule")]
        public string schedule { get; set; }
        [JsonProperty("run-on")]
        public int runOn { get; set; }
        [JsonProperty("receive-email-alerts")]
        public string receiveEmailAlerts { get; set; }
        [JsonProperty("email-addresses")]
        public List<string> emailAddresses { get; set; }
        [JsonProperty("is-public")]
        public string isPublic { get; set; }
        [JsonProperty("directories")]
        public RFDirectoryUrls directories { get; set; }
        [JsonProperty("run-report")]
        public string runReport { get; set; }
    }
 
}

