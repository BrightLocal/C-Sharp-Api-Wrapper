using System;
using System.Collections.Generic;

namespace BrightLocal
{
    public class BlRfGetAll
    {
        public bool success { get; set; }
        public List<RfReports> reports { get; set; }
    }

    public class RfReports
    {
        public string report_id { get; set; }
        public string report_name { get; set; }
        public string location_id { get; set; }
        public string created_at { get; set; }
        public string last_update { get; set; }
        public bool is_running { get; set; }
        public string running_message { get; set; }
        public bool fetching { get; set; }
        public bool complete { get; set; }
    }
}
