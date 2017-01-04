using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalLscuReport
    {
        public string report_id { get; set; }
        public string customer_id { get; set; }
        public string location_id { get; set; }
        public string company_name { get; set; }
        public string name { get; set; }
        public string white_label_profile_id { get; set; }
        public string business_names { get; set; }
        public string website_address { get; set; }
        public string telephone { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string area { get; set; }
        public string city { get; set; }
        public string state_code { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string business_category { get; set; }
        public string primary_business_location { get; set; }
        public string search_terms { get; set; }
        public string notify { get; set; }
        public string email_addresses { get; set; }
        public string date_added { get; set; }
        public string last_start_time { get; set; }
        public string last_end_time { get; set; }
        public string last_message { get; set; }
        public string generation_error { get; set; }
        public string currently_running { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string google_location { get; set; }
        public string bing_location { get; set; }
        public object previous_bing_location { get; set; }
        public string is_public { get; set; }
        public string public_key { get; set; }
        public LatestRun latest_run { get; set; }
    }

    public class LatestRun
    {
        public string interactive_url { get; set; }
        public string pdf_url { get; set; }
        public string public_interactive_url { get; set; }
        public string public_pdf_url { get; set; }
    }
}
