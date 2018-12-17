using System.Collections.Generic;

namespace BrightLocal
{
    public class BlCbCampaign
    {
        public CampaignResponse response { get; set; }
    }

    public class CampaignResponse
    {
        public CampaignResults results { get; set; }
    }

    public class CampaignResults
    {
        public string campaign_id { get; set; }
        public int location_id { get; set; }
        public string campaign_name { get; set; }
        public string creation_date { get; set; }
        public string package_id { get; set; }
        public string selection_type { get; set; }
        public string paid { get; set; }
        public string status { get; set; }
        public string submission_date { get; set; }
        public string purchase_date { get; set; }
        public string completion_date { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string campaign_note { get; set; }
        public string customer_note { get; set; }
        public string white_label_profile_id { get; set; }
        public string num_citations { get; set; }
        public string package_price { get; set; }
        public string website_address { get; set; }
        public string campaign_country { get; set; }
        public string campaign_state { get; set; }
        public string campaign_city { get; set; }
        public string business_category_id { get; set; }
        public string business_category_name { get; set; }
        public CampaignAddress address { get; set; }
        public CampaignContact contact { get; set; }
        public string mobile_number { get; set; }
        public string fax_number { get; set; }
        public CampaignDescriptions descriptions { get; set; }
        public string num_employees { get; set; }
        public string start_year { get; set; }
        public ServiceNames service_names { get; set; }
        public WorkingHours working_hours { get; set; }
        public PaymentMethods payment_methods { get; set; }
        public object company_logo { get; set; }
        public CampaignPhotos photos { get; set; }
        public CbEmailAlerts email_alerts { get; set; }
        public string old_business_name { get; set; }
        public List<object> specialist_info { get; set; }
        public List<Stat> stats { get; set; }
        public List<CampaignCitation> citations { get; set; }
        public List<CampaignAggregator> aggregators { get; set; }
        public CampaignUrls urls { get; set; }
    }

    public class Stat
    {
        public string start_date { get; set; }
        public int citations_count { get; set; }
        public int scheduled { get; set; }
        public int submitted { get; set; }
        public int live { get; set; }
        public int updated { get; set; }
        public int replaced { get; set; }
    }

    public class CampaignCitation
    {
        public string site { get; set; }
        public string type { get; set; }
        public string domain_authority { get; set; }
        public string status { get; set; }
        public string link { get; set; }
        public string notes { get; set; }
    }

    public class CampaignAggregator
    {
        public string site { get; set; }
        public string type { get; set; }
        public string domain_authority { get; set; }
        public string status { get; set; }
        public string link { get; set; }
        public string notes { get; set; }
    }

    public class CampaignUrls
    {
        public string interactive_url { get; set; }
        public string pdf_url { get; set; }
        public string csv_url { get; set; }
    }

    public class CbEmailAlerts
    {
        public string enabled { get; set; }
        public List<string> addresses { get; set; }
    }

    public class CampaignPhotos : Dictionary<string, string>
    {

    }

    public class PaymentMethods : Dictionary<string, string>
    {

    }

    public class ServiceNames : Dictionary<string, string>
    {

    }

    public class CampaignDescriptions
    {
        public string brief { get; set; }
        public string full { get; set; }
    }

    public class CampaignContact
    {
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
    }

    public class CampaignAddress
    {
        public string street_address_1 { get; set; }
        public object street_address_2 { get; set; }
        public object city { get; set; }
        public object region { get; set; }
        public string postcode { get; set; }
    }

}
