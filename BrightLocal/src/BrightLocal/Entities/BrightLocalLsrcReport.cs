using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalLsrcReport
    {
        [JsonProperty("campaign_id")]
        public string campaign_id { get; set; }
        [JsonProperty("customer_id")]
        public string customer_id { get; set; }
        [JsonProperty("white_label_profile_id")]
        public string white_label_profile_id { get; set; }
        [JsonProperty("location_id")]
        public string location_id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("schedule")]
        public string schedule { get; set; }
        [JsonProperty("day_of_week")]
        public string day_of_week { get; set; }
        [JsonProperty("day_of_month")]
        public object day_of_month { get; set; }
        [JsonProperty("search_terms")]
        public List<string> search_terms { get; set; }
        [JsonProperty("ppc_search_terms")]
        public object ppc_search_terms { get; set; }
        [JsonProperty("lookup_ppc")]
        public string lookup_ppc { get; set; }
        [JsonProperty("website-addresses")]
        public List<string> websiteAddresses { get; set; }
        [JsonProperty("website_address")]
        public string website_address { get; set; }
        [JsonProperty("website_address_2")]
        public object website_address_2 { get; set; }
        [JsonProperty("website_address_3")]
        public object website_address_3 { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("google_location")]
        public string google_location { get; set; }
        [JsonProperty("bing_location")]
        public object bing_location { get; set; }
        [JsonProperty("business_names")]
        public List<string> business_names { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("telephone")]
        public string telephone { get; set; }
        [JsonProperty("search_engines")]
        public List<string> search_engines { get; set; }
        [JsonProperty("include_local_directory_results")]
        public string include_local_directory_results { get; set; }
        [JsonProperty("notify")]
        public string notify { get; set; }
        [JsonProperty("email_addresses")]
        public List<string> email_addresses { get; set; }
        [JsonProperty("created")]
        public string created { get; set; }
        [JsonProperty("last_processed")]
        public string last_processed { get; set; }
        [JsonProperty("last_message")]
        public string last_message { get; set; }
        [JsonProperty("currently_running")]
        public string currently_running { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("red_flag")]
        public string red_flag { get; set; }
        [JsonProperty("is_public")]
        public string is_public { get; set; }
        [JsonProperty("public_key")]
        public object public_key { get; set; }
        [JsonProperty("tags")]
        public List<string> tags { get; set; }
    }
}
