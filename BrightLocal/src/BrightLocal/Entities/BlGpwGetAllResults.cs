using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlGpwGetAllResults
    {
        public GpwResponse response { get; set; }
    }

    public class GpwResponse
    {
        public List<GpwGetAllResult> results { get; set; }
    }

    public class GpwGetAllResult
    {
        public string report_id { get; set; }
        public string report_name { get; set; }
        public string schedule { get; set; }
        public string is_running { get; set; }
        public string running_message { get; set; }
    }
}
