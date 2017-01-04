using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalLscuSearch
    {
        public bool success { get; set; }
        public List<Report> reports { get; set; }
    }

    public class Report
    {
        public string report_id { get; set; }
        public string report_name { get; set; }
        public string location_id { get; set; }
        public string date_added { get; set; }
        public string last_run_date { get; set; }
        public string last_message { get; set; }
        public string currently_running { get; set; }
    }
}
