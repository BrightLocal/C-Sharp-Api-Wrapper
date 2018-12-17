using System.Collections.Generic;

namespace BrightLocal
{
    public class BlRfReviews
    {
        public bool success { get; set; }
        public List<Review> reviews { get; set; }
    }

    public class Review
    {
        public string dt { get; set; }
        public string report_id { get; set; }
        public string directory { get; set; }
        public string timestamp { get; set; }
        public string rating { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string text { get; set; }
        public string link { get; set; }
        public string url { get; set; }
        public string source { get; set; }
        public string name { get; set; }
        public string report_run_id { get; set; }
    }
}
