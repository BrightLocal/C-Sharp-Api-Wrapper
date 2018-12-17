using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class RankingsSearchOptions 
    {
        public RankingsSearchOptions()
        {
            searches = new List<SearchOptions>();
        }

       public List<SearchOptions> searches { get; set; }
    }
    public class SearchOptions
    {
       
        [JsonProperty("search-engine")]
        public string searchEngine {get;set;}
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("google-location")]
        public string googleLocation { get; set; }
        [JsonProperty("bing-location")]
        public string bingLocation { get; set; }
        [JsonProperty("search-term")]
        public string searchTerm { get; set; }
        public string urls { get; set; }
        [JsonProperty("business-names")]
        public string businessNames { get; set; }
        [JsonProperty("postcode")]
        public string postcode { get; set; }
        [JsonProperty("telephone")]
        public string telephone { get; set; }
        [JsonProperty("include-secondary-matches")]
        public string includeSecondaryMatches { get; set; }
        [JsonProperty("listings")]
        public string listings { get; set; }
        [JsonProperty("screenshots")]
        public string screenshots { get; set; }

    }
}
