using System.Collections.Generic;


namespace BrightLocal
{
    public class BlGpwReport
    {
        public bool success { get; set; }
        public GpwReport report { get; set; }
    }

    public class GpwReport
    {
        public string report_id { get; set; }
        public string report_name { get; set; }
        public string customer_id { get; set; }
        public string location_id { get; set; }
        public string schedule { get; set; }
        public string day_of_month { get; set; }
        public string white_label_profile_id { get; set; }
        public string report_type { get; set; }
        public List<string> business_names { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string state_code { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string telephone { get; set; }
        public string profile_url { get; set; }
        public List<string> search_terms { get; set; }
        public string google_location { get; set; }
        public string notify { get; set; }
        public List<string> email_addresses { get; set; }
        public string last_run_id { get; set; }
        public string is_public { get; set; }
        public string public_key { get; set; }
        public string status { get; set; }
    }
}
