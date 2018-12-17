using Newtonsoft.Json;
using RestSharp;


namespace BrightLocal
{
    public class UpdateLocation
    {
        [JsonRequired]
        [JsonProperty("location-id")]
        public int locationId { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("client-id")]
        public int clientId { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
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
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("telephone")]
        public string telephone { get; set; }
        [JsonProperty("unique-reference")]
        public string uniqueReference { get; set; }
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
        public JsonArray extraBusinessCategories { get; set; }
        [JsonProperty("working-hours")]
        public JsonArray workingHours { get; set; }
        [JsonProperty("payment-methods")]
        public JsonArray paymentMethods { get; set; }
        [JsonProperty("short-description")]
        public string shortDescription { get; set; }
        [JsonProperty("long-description")]
        public string longDescription { get; set; }
        [JsonProperty("services-of-products")]
        public JsonArray servicesOfProducts { get; set; }
    }
}
