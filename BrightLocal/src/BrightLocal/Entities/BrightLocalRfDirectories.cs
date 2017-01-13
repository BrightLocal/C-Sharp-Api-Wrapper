using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalRfDirectories
    {
        public bool success { get; set; }
        public RflowDirectories directories { get; set; }
    }

    public class BrightLocalRfDirectoryStats
    {
        public bool success { get; set; }
        public RflowDirectories stats { get; set; }
    }

    public class BrightLocalRfStarCounts
    {
        public bool success { get; set; }
        public StarCounts counts { get; set; }
    }

    public class RflowDirectories : Dictionary<string, ReviewfDirectories>
    {

    }

    public class ReviewfDirectories
    {
        public string directory { get; set; }
        public string name { get; set; }
        public bool use { get; set; }
        public string url { get; set; }
        public bool searched { get; set; }
        public int reviews { get; set; }
    }

    public class StarCounts
    {
        [JsonProperty("0star")]
        public string star0 { get; set; }
        [JsonProperty("1star")]
        public string star1 { get; set; }
        [JsonProperty("2star")]
        public string star2 { get; set; }
        [JsonProperty("3star")]
        public string star3 { get; set; }
        [JsonProperty("4star")]
        public string star4 { get; set; }
        [JsonProperty("5star")]
        public string star5 { get; set; }

    }
}
