using System.Collections.Generic;

namespace BrightLocal
{
    public class BlGetAllResults
    {
        public LsrcGetAllResponse response { get; set; }        
    }
    public class LsrcGetAllResponse
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
