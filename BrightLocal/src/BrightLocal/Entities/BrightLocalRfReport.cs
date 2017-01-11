using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalRfReport
    {
        public bool success { get; set; }
        public RfReport report { get; set; }
    }

    public class RfReport
    {
        public string report_id { get; set; }
        public string report_name { get; set; }
        public string location_id { get; set; }
        public string customer_id { get; set; }
        public string business_name { get; set; }
        public string contact_telephone { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public bool receive_email_alerts { get; set; }
        public List<string> alert_email_addresses { get; set; }
        public string last_update { get; set; }
        public string created_at { get; set; }
        public string schedule { get; set; }
        public string run_on { get; set; }
        public string reviews_count { get; set; }
        public string rating { get; set; }
        public bool is_running { get; set; }
        public string white_label_profile_id { get; set; }
        public bool is_public { get; set; }
        public string public_key { get; set; }
        public RfDirectories directories { get; set; }
        public RfUrls urls { get; set; }
    }

    public class RfUrls
    {
        public string interactive_url { get; set; }
        public string pdf_url { get; set; }
        public string public_interactive_url { get; set; }
        public string public_pdf_url { get; set; }
    }

    public class RfDirectories : Dictionary<string, RfDirectoryUrls>
    {

    }

    public class RfDirectoryUrls
    {
        public string url { get; set; }
        public bool searched { get; set; }
        public bool include { get; set; }
    }
}
