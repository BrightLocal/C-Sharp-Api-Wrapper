using System.Collections.Generic;

namespace BrightLocal
{
    public class BrightLocalGpwReportResults
    {
        public bool success { get; set; }
        public GpwReportResults results { get; set; }
    }

    public class GpwReportResults
    {
        public GpwSummary summary { get; set; }
        public GpwKeywords keywords { get; set; }
        public GpwReportUrls urls { get; set; }
    }

    public class GpwSummary
    {
        public string business_name { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string website_address { get; set; }
        public List<string> opening_hours { get; set; }
        public string profile_url { get; set; }
        public bool claimed { get; set; }
        public int citations_count { get; set; }
        public double domain_authority { get; set; }
        public int backlinks { get; set; }
        public int num_reviews { get; set; }
        public int star_rating { get; set; }
        public string review_content { get; set; }
        public int num_photos { get; set; }
        public List<string> categories { get; set; }
    }

    public class GpwKeywords : Dictionary<string, GpwKeywordsResults>
    {

    }

    public class GpwKeywordsResults
    {
        public int client_rank { get; set; }
        public List<GpwTop10> top_10 { get; set; }
        public List<CitationsMatrix> citations_matrix { get; set; }
        public List<NapComparison> nap_comparison { get; set; }
        public TopCategories top_categories { get; set; }
        public List<object> other_ranking_factors { get; set; }
    }

    public class GpwTop10
    {
        public string business_name { get; set; }
        public string rank { get; set; }
        public bool client_business { get; set; }
        public string profile_url { get; set; }
        public bool claimed { get; set; }
        public int citations_count { get; set; }
        public string domain_authority { get; set; }
        public int backlinks { get; set; }
        public int num_reviews { get; set; }
        public string star_rating { get; set; }
        public int num_photos { get; set; }
        public List<string> categories { get; set; }
    }

    public class CitationsMatrix
    {
        public string domain { get; set; }
        public string authority { get; set; }
        public int count { get; set; }
        public List<GpwBusiness> businesses { get; set; }
    }

    public class GpwBusiness
    {
        public string business_name { get; set; }
        public string citations_count { get; set; }
        public string url { get; set; }
    }

    public class NapComparison
    {
        public string taken_from { get; set; }
        public string business_name { get; set; }
        public string address { get; set; }
        public string postcode { get; set; }
        public string telephone { get; set; }
    }

    public class TopCategories : Dictionary<string, int>
    {

    }

    public class GpwReportUrls
    {
        public string report_url { get; set; }
        public string wl_url { get; set; }
    }

}
