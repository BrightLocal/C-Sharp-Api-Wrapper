using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class UpdateCitationBurstOptions
    {
        
        public int campaignId { get; set; }
        [JsonProperty("location_id")]
        public int locationId { get; set; }
        [JsonProperty("business_name")]
        public string businessName { get; set; }
        [JsonProperty("campaign_name")]
        public string campaignName { get; set; }
        [JsonProperty("website_address")]
        public string websiteAddress { get; set; }
        [JsonProperty("campaign_country")]
        public string campaignCountry { get; set; }
        [JsonProperty("campaign_state")]
        public string campaignState { get; set; }
        [JsonProperty("campaign_city")]
        public string campaignCity { get; set; }
        [JsonProperty("business_category_id")]
        public int businessCategoryId { get; set; }
        [JsonProperty("business_categories")]
        public List<string> businessCategories { get; set; }
        [JsonProperty("address1")]
        public string address1 { get; set; }
        [JsonProperty("address2")]
        public string address2 { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("contact_name")]
        public string contactName { get; set; }
        [JsonProperty("contact_firstname")]
        public string contactFirstName { get; set; }
        [JsonProperty("contact_telephone")]
        public string contactTelephone { get; set; }
        [JsonProperty("mobile_number")]
        public string mobileNumber { get; set; }
        [JsonProperty("fax_number")]
        public string faxNumber { get; set; }
        [JsonProperty("brief_description")]
        public string briefDescription { get; set; }
        [JsonProperty("full_description")]
        public string fullDescription { get; set; }
        [JsonProperty("employees_number")]
        public int employeesNumber { get; set; }
        [JsonProperty("start_year")]
        public int startYear { get; set; }
        [JsonProperty("service_name_1")]
        public string serviceName1 { get; set; }
        [JsonProperty("service_name_2")]
        public string serviceName2 { get; set; }
        [JsonProperty("service_name_3")]
        public string serviceName3 { get; set; }
        [JsonProperty("service_name_4")]
        public string serviceName4 { get; set; }
        [JsonProperty("service_name_5")]
        public string serviceName5 { get; set; }
        [JsonProperty("working_hours_apply_to_all")]
        public int workingHoursApplyToAll { get; set; }
        [JsonProperty("working_hours_mon_start")]
        public int workingHoursMonStart { get; set; }
        [JsonProperty("working_hours_mon_end")]
        public int workingHoursMonEnd { get; set; }
        [JsonProperty("working_hours_tue_start")]
        public int workingHoursTueStart { get; set; }
        [JsonProperty("working_hours_tue_end")]
        public int workingHoursTueEnd { get; set; }
        [JsonProperty("working_hours_wed_start")]
        public int workingHoursWedStart { get; set; }
        [JsonProperty("working_hours_Wed_end")]
        public int workingHoursWedEnd { get; set; }
        [JsonProperty("working_hours_thu_start")]
        public int workingHoursThuStart { get; set; }
        [JsonProperty("working_hours_thu_end")]
        public int workingHoursThuEnd { get; set; }
        [JsonProperty("working_hours_fri_start")]
        public int workingHoursFriStart { get; set; }
        [JsonProperty("working_hours_fri_end")]
        public int workingHoursFriEnd { get; set; }
        [JsonProperty("working_hours_sat_start")]
        public int workingHoursSatStart { get; set; }
        [JsonProperty("working_hours_sat_end")]
        public int workingHoursSatEnd { get; set; }
        [JsonProperty("working_hours_mon_start")]
        public int workingHoursSunStart { get; set; }
        [JsonProperty("working_hours_mon_end")]
        public int workingHoursSunEnd { get; set; }
        [JsonProperty("special_offer")]
        public string specialOffer { get; set; }
        [JsonProperty("special_offer_description")]
        public string specialOfferDescription { get; set; }
        [JsonProperty("special_offer_expiration_date")]
        public string specialOfferExpirationDate { get; set; }
        [JsonProperty("payment_methods")]
        public string paymentMethods { get; set; }
        [JsonProperty("receive-email-alerts")]
        public string receiveEmailAlerts { get; set; }
        [JsonProperty("alert-email-addresses")]
        public string alertEmailAddresses { get; set; }
        [JsonProperty("old_business_name")]
        public string oldBusinessName { get; set; }
        [JsonProperty("old_lookup_data")]
        public string oldLookUpData { get; set; }
        [JsonProperty("is_public")]
        public string isPublic { get; set; }
    }
}
