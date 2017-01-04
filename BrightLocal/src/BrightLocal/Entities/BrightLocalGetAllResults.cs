using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalGetAllResults
    {
        public List<ResultsList> results { get; set; }
    }

    public class ResultsList
    {
        public string campaign_id { get; set; }
        public string name { get; set; }
        public string schedule { get; set; }
        public string day_of_week { get; set; }
        public string day_of_month { get; set; }
        public string location_id { get; set; }
    }

}
