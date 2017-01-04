using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalCitationTrackerGetAll
    {
        public List<CitationTrackerAll> results { get; set; }
    }

    public class CitationTrackerAll
    {
        public string campaign_id { get; set; }
        public string name { get; set; }
        public string schedule { get; set; }
        public string day_of_week { get; set; }
        public string day_of_month { get; set; }
        public string location_id { get; set; }
    }

}
