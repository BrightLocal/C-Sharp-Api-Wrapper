using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalLsrcReportResults
    {
        public LsrcResultResponse response { get; set; }
    }

    public class LsrcResultResponse
    {
        public LsrcReportResult result { get; set; }
    }

    public class LsrcReportResult
    {
        public LsrcCampaignDetails campaign_details { get; set; }
        public LsrcResultsUrls urls { get; set; }
        public LsrcResultsRankings rankings { get; set; }
        [JsonProperty("serp-screenshots")]
        public List<LsrcSerpScreenshots> serpScreenshots { get; set; }
    }

    public class LsrcCampaignDetails
    {
        public string campaign_id { get; set; }
        public string customer_id { get; set; }
        public string white_label_profile_id { get; set; }
        public string location_id { get; set; }
        public string name { get; set; }
        public string schedule { get; set; }
        public string day_of_week { get; set; }
        public string day_of_month { get; set; }
        public List<string> search_terms { get; set; }
        public string ppc_search_terms { get; set; }
        public string lookup_ppc { get; set; }
        public List<string> website_addresses { get; set; }
        public string country { get; set; }
        public string google_location { get; set; }
        public string bing_location { get; set; }
        public object previous_bing_location { get; set; }
        public List<string> business_names { get; set; }
        public string postcode { get; set; }
        public string telephone { get; set; }
        public List<string> search_engines { get; set; }
        public string include_local_directory_results { get; set; }
        public string notify { get; set; }
        public string email_addresses { get; set; }
        public string created { get; set; }
        public string last_processed { get; set; }
        public string last_message { get; set; }
        public string currently_running { get; set; }
        public string status { get; set; }
        public string red_flag { get; set; }
        public string is_public { get; set; }
        public string public_key { get; set; }
        public string show_advanced_settings { get; set; }
        public string last_batch_id { get; set; }
        public List<string> tags { get; set; }
    }

    public class LsrcResultsUrls
    {
        public string interactive_url { get; set; }
        public string pdf_url { get; set; }
        public string csv_url { get; set; }
        public string public_interactive_url { get; set; }
        public string public_pdf_url { get; set; }
        public string public_csv_url { get; set; }
    }

    public class LsrcResultsRankings
    {
        public List<string> keywords { get; set; }
        public KeywordsNumRankings keywords_num_rankings { get; set; }
        public List<string> search_engines { get; set; }
        public LsrcResultsRankings2 rankings { get; set; }
        public LsrcHashes hashes { get; set; }
        public LsrcByPosition byPosition { get; set; }
        public Dictionary<string, bool> starred_keywords { get; set; }
        public LsrcSummary summary { get; set; }
    }

    public class KeywordsNumRankings: Dictionary<string, string>
    {

    }

    public class LsrcResultsRankings2: Dictionary<string, LsrcKeyword>
    {

    }

    public class LsrcKeyword: Dictionary<string, List<LsrcEngines>>
    {

    }
    public class LsrcEngines
    {
        public string id { get; set; }
        public string url { get; set; }
        public string orig_url { get; set; }
        public string rank { get; set; }
        public string page { get; set; }
        public string type { get; set; }
        public string match { get; set; }
        public string directory { get; set; }
        public string date { get; set; }
        public string hash { get; set; }
        public string search_url { get; set; }
        public string search_engine { get; set; }
    }

    public class LsrcHashes: Dictionary<string, HashKeyword>
    {

    }

    public class HashKeyword: Dictionary<string, List<string>>
    {

    }

    public class LsrcByPosition
    {
        [JsonProperty("Position 1")]
        public List<LsrcPositionValues> Position1 { get; set; }
        [JsonProperty("Positions 2-5")]
        public List<LsrcPositionValues> Positions2_5 { get; set; }
        [JsonProperty("Positions 6-10")]
        public List<LsrcPositionValues> Positions6_10 { get; set; }
        [JsonProperty("Positions 11-20")]
        public List<LsrcPositionValues> Positions11_20 { get; set; }
        [JsonProperty("Positions 21-50")]
        public List<LsrcPositionValues> Positions21_50 { get; set; }
        [JsonProperty("Positions 51+")]
        public LsrcPositionValues Positions51Up { get; set; }
    }

    public class LsrcPositions
    {
        
    }

    public class LsrcPositionValues: Dictionary<string, LsrcPositionDetails>
    {
       
    }

    public class LsrcPositionDetails
    {
        public string id { get; set; }
        public string url { get; set; }
        public string orig_url { get; set; }
        public string rank { get; set; }
        public string page { get; set; }
        public string type { get; set; }
        public string match { get; set; }
        public object directory { get; set; }
        public string date { get; set; }
        public string hash { get; set; }
        public string search_url { get; set; }
        public string search_engine { get; set; }
    }

    public class LsrcSummary
    {
        public LsrcAllSearchEngines all_search_engines { get; set; }
        public LsrcGoogle google { get; set; }
        [JsonProperty("google-places")]
        public LsrcGooglePlaces googlePlaces { get; set; }
        public LsrcYahoo yahoo { get; set; }
        [JsonProperty("yahoo-local")]
        public LsrcYahooLocal yahooLocal { get; set; }
        public LsrcBing bing { get; set; }
        [JsonProperty("bing-local")]
        public LsrcBingLocal bingLocal { get; set; }
    }

    public class LsrcAllSearchEngines
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcGoogle
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcGooglePlaces
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcYahoo
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcYahooLocal
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcBing
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcBingLocal
    {
        public int up { get; set; }
        public int down { get; set; }
        public int no_change { get; set; }
        public List<object> gained_hashes { get; set; }
        public List<object> lost_hashes { get; set; }
    }

    public class LsrcSerpScreenshots: Dictionary<string, ScreenshotKeyword>
    {

    }

    public class ScreenshotEngine: Dictionary<string, ScreenshotKeyword>
    {

    }

    public class ScreenshotKeyword: Dictionary<string, ScreenshotPosition>
    {

    }

    public class ScreenshotPosition
    {
        public string url { get; set; }
        public string expiry_date { get; set; }
    }
}
