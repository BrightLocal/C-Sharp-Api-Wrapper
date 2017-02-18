using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlCitationTrackerReport
    {
        public bool success { get; set; }
        public CtReport report { get; set; }
    }

    public class CtReport
    {
        public string report_id { get; set; }
        public string customer_id { get; set; }
        public string location_id { get; set; }
        public string weekly_run { get; set; }
        public string monthly_run { get; set; }
        public string report_name { get; set; }
        public string website_address { get; set; }
        public string business_name { get; set; }
        public string business_location { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public object state_code { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string telephone { get; set; }
        public string business_type { get; set; }
        public string primary_location { get; set; }
        public string last_run_id { get; set; }
        public string old_business_name_1 { get; set; }
        public string old_postcode_1 { get; set; }
        public string old_business_name_2 { get; set; }
        public string old_postcode_2 { get; set; }
        public string last_run { get; set; }
        public string company_name { get; set; }
        public string white_label_profile_id { get; set; }
        public string notify { get; set; }
        public string email_addresses { get; set; }
        public string active_only { get; set; }
        public string is_public { get; set; }
        public string public_key { get; set; }
        public string created { get; set; }
        public string status { get; set; }
        public CtUrls urls { get; set; }
    }

    public class CtUrls
    {
        public string interactive_url { get; set; }
        public string pdf_url { get; set; }
        public string csv_url { get; set; }
        public string public_interactive_url { get; set; }
        public string public_pdf_url { get; set; }
        public string public_csv_url { get; set; }
    }
}
