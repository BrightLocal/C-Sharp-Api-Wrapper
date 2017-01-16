using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalCtGetAllResults
    {
        public CtGetAllResponse response { get; set; }
    }
    public class CtGetAllResponse
    {
        public List<CtResult> results { get; set; }
    }

    public class CtResult
    {
        public string report_id { get; set; }
        public string customer_id { get; set; }
        public string location_id { get; set; }
        public string report_run_id { get; set; }
        public string report_name { get; set; }
        public string website_address { get; set; }
        public string business_name { get; set; }
        public string business_location { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string state_code { get; set; }
        public string cancel_run { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string telephone { get; set; }
        public string business_type { get; set; }
        public string primary_location { get; set; }
        public string old_business_name_1 { get; set; }
        public string old_postcode_1 { get; set; }
        public string old_business_name_2 { get; set; }
        public string old_postcode_2 { get; set; }
        public string currently_running { get; set; }
        public string generation_error { get; set; }
        public string terminal_fail { get; set; }
        public string last_run { get; set; }
        public object report_status { get; set; }
        public string your_ct_count { get; set; }
        public string your_ct_count_up { get; set; }
        public string your_ct_count_down { get; set; }
        public string total_ct_sources { get; set; }
        public string total_ct_sources_up { get; set; }
        public string competitor_ct_count { get; set; }
        public string competitor_ct_count_diff { get; set; }
        public string old_ct_count { get; set; }
        public object company_name { get; set; }
        public object branding_profile_id { get; set; }
        public string notify { get; set; }
        public string email_addresses { get; set; }
        public int your_ct_count_diff { get; set; }
        public int competitor_ct_count_up { get; set; }
        public int competitor_ct_count_down { get; set; }
        public int total_ct_sources_diff { get; set; }
        public string successful_runs { get; set; }
    }
}
