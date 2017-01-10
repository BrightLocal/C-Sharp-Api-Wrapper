using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalCbCampaign
    {
        public CampaignResponse response { get; set; }
    }

    public class CampaignResponse
    {
        public CampaignResults results { get; set; }
    }

    public class CampaignResults
    {
        public string campaign_id { get; set; }
        public string purchase_date { get; set; }
        public string completion_date { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<Stat> stats { get; set; }
        public List<CampaignCitation> citations { get; set; }
        public List<CampaignAggregator> aggregators { get; set; }
        public int location_id { get; set; }
        public CampaignUrls urls { get; set; }
    }

    public class Stat
    {
        public string start_date { get; set; }
        public int citations_count { get; set; }
        public int scheduled { get; set; }
        public int submitted { get; set; }
        public int live { get; set; }
        public int updated { get; set; }
        public int replaced { get; set; }
    }

    public class CampaignCitation
    {
        public string site { get; set; }
        public string type { get; set; }
        public string domain_authority { get; set; }
        public string status { get; set; }
        public string link { get; set; }
        public string notes { get; set; }
    }

    public class CampaignAggregator
    {
        public string site { get; set; }
        public string type { get; set; }
        public string domain_authority { get; set; }
        public string status { get; set; }
        public string link { get; set; }
        public string notes { get; set; }
    }

    public class CampaignUrls
    {
        public string interactive_url { get; set; }
        public string pdf_url { get; set; }
        public string csv_url { get; set; }
    }
}
