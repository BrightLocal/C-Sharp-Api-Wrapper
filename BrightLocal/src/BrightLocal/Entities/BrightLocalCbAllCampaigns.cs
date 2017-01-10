using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalCbAllCampaigns
    {
        public CbResponse response { get; set; }
    }

    public class CbResponse
    {
        public List<CbResult> results { get; set; }
    }

    public class CampaignsCitation
    {
        public string name { get; set; }
        public string status { get; set; }
        public string site_type { get; set; }
        public string citation_url { get; set; }
        public string domain_authority { get; set; }
        public string citation_value { get; set; }
    }

    public class CbAggregator
    {
        public string name { get; set; }
        public string status { get; set; }
        public string site_type { get; set; }
        public string citation_url { get; set; }
        public string domain_authority { get; set; }
        public string citation_value { get; set; }
    }

    public class CbResult
    {
        public string campaign_id { get; set; }
        public string location_id { get; set; }
        public string campaign_name { get; set; }
        public string date_purchased { get; set; }
        public string date_completed { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<CampaignsCitation> citations { get; set; }
        public List<CbAggregator> aggregators { get; set; }
    }
}
