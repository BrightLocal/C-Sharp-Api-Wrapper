using Newtonsoft.Json;


namespace BrightLocal
{
    public class GetResultsLsrcOptions
    {
        [JsonProperty("campaign-id")]
        public int campaignId { get; set; }
        [JsonProperty("campaign-history-id")]
        public int campaignHistoryId { get; set; }
        [JsonProperty("previous-campaign-history-id")]
        public int previousCampaignHistoryId { get; set; }
    }
}
