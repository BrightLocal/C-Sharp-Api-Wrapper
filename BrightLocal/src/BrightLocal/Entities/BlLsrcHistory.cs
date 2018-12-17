using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlLsrcHistory
    {
        public LsrcHistoryResponse response { get; set; }        
    }
    public class LsrcHistoryResponse
    {
        public List<LsrcHistory> results { get; set; }
    }

    public class LsrcHistory
    {
        [JsonProperty("campaign_history_id")]
        public string campaignHistoryId { get; set; }
        [JsonProperty("campaign_id")]
        public string campaignId { get; set; }
        [JsonProperty("location_id")]
        public string locationId { get; set; }
        [JsonProperty("hystory_type")]
        public string historyType { get; set; }
        [JsonProperty("generation_date")]
        public string genrationDate { get; set; }
    }
}
