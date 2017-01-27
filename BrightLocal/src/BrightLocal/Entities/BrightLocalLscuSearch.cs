using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalLscuSearch
    {
        [JsonProperty("success")]
        public bool success { get; set; }
        [JsonProperty("reports")]
        public List<LscuReports> reports { get; set; }
    }

    public class LscuReports
    {
        [JsonProperty("report_id")]
        public string report_id { get; set; }
        [JsonProperty("report_name")]
        public string report_name { get; set; }
        [JsonProperty("location_id")]
        public string location_id { get; set; }
        [JsonProperty("date_added")]
        public string date_added { get; set; }
        [JsonProperty("last_run_date")]
        public string last_run_date { get; set; }
        [JsonProperty("last_message")]
        public string last_message { get; set; }
        [JsonProperty("currently_running")]
        public string currently_running { get; set; }
    }
}
