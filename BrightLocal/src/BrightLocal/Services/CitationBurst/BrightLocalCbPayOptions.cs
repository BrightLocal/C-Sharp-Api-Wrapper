using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalCbPayOptions
    {
        public int campaign_id { get; set; }
        public string package_id { get; set; }
        public string aurtoselect { get; set; }
        public List<string> citations { get; set; }
        [JsonProperty("remove-duplicates")]
        public string removeDuplicates { get; set; }
        public List<string> aggregators { get; set; }
        public string notes { get; set; }

    }
}
