using System.Collections.Generic;

namespace BrightLocal
{
    public class BlCitations
    {
        public bool error { get; set; }
        public int campaignId { get; set; }
        public Citations citations { get; set; }
        public List<Aggregator> aggregators { get; set; }
    }

    public class Citations : Dictionary<string, Citation>
    {

    }

    public class Citation
    {
        public string citation_value { get; set; }
        public string domain_authority { get; set; }
        public string type { get; set; }
        public string phone_verification { get; set; }
        public string client_verification { get; set; }
        public string notes { get; set; }
        public string no_update { get; set; }
        public string no_photos { get; set; }
        public string part_of_yext_network { get; set; }
        public string quick_listing { get; set; }
        public string secondary_campaign_id { get; set; }
        public string status { get; set; }
    }

    public class Aggregator
    {
        public string citation { get; set; }
        public string domain_authority { get; set; }
        public string type { get; set; }
        public string phone_verification { get; set; }
        public string client_verification { get; set; }
        public string notes { get; set; }
        public string no_update { get; set; }
        public string no_photos { get; set; }
        public string part_of_yext_network { get; set; }
        public string quick_listing { get; set; }
        public string secondary_campaign_id { get; set; }
        public string status { get; set; }
    }
}
