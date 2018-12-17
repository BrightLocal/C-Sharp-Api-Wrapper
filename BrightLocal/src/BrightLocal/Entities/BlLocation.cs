using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace BrightLocal
{
    public class BlLocation
    {
        [JsonProperty("location-name")]
        public string locationName { get; set; }
        [JsonProperty("client-id")]
        public int clientId { get; set; }
        [JsonProperty("location-url")]
        public string locationUrl { get; set; }
        [JsonProperty("business-category-id")]
        public int businessCategoryId { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("address1")]
        public string address1 { get; set; }
        [JsonProperty("address2")]
        public string address2 { get; set; }
        [JsonProperty("region")]
        public string region { get; set; }
        [JsonProperty("town")]
        public string town { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("telephone")]
        public string telephone { get; set; }
        [JsonProperty("location-reference")]
        public string locationReference { get; set; }
        [JsonProperty("contact-first-name")]
        public string contactFirstName { get; set; }
        [JsonProperty("contact-last-name")]
        public string contactLastName { get; set; }
        [JsonProperty("contact-mobile")]
        public string contactMobile { get; set; }
        [JsonProperty("contact-telephone")]
        public string contactTelephone { get; set; }
        [JsonProperty("contact-email")]
        public string contactEmail { get; set; }
        [JsonProperty("contact-fax")]
        public string contactFax { get; set; }
        [JsonProperty("number-of-employees")]
        public string numberOfEmployees { get; set; }
        [JsonProperty("year-of-formation")]
        public string yearOfFormation { get; set; }
        [JsonProperty("extra-business-categories")]
        public List<string> extraBusinessCategories { get; set; }
        [JsonProperty("working-hours")]
        public List<WorkingHours> workingHours { get; set; }
        [JsonProperty("payment-methods")]
        public List<string> paymentMethods { get; set; }
        [JsonProperty("short-description")]
        public string shortDescription { get; set; }
        [JsonProperty("long-description")]
        public string longDescription { get; set; }
        [JsonProperty("services-of-products")]
        public List<string> servicesOfProducts { get; set; }
    }

    public class WorkingHours : Dictionary<string, string>
    {
        //public string mon_start { get; set; }
        //public string mon_end { get; set; }
        //public string tue_start { get; set; }
        //public string tue_end { get; set; }
        //public string wed_start { get; set; }
        //public string wed_end { get; set; }
        //public string thu_start { get; set; }
        //public string thu_end { get; set; }
        //public string fri_start { get; set; }
        //public string fri_end { get; set; }
        //public string sat_start { get; set; }
        //public string sat_end { get; set; }
        //public string sun_start { get; set; }
        //public string sun_end { get; set; }
    }
}
