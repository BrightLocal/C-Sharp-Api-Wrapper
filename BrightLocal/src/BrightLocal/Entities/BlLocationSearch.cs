
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BrightLocal
{
    public class BlLocationSearch
    {
        [JsonProperty("success")]
        public bool success { get; set; }
        [JsonProperty("locations")]
        public List<Location> locations { get; set; }
    }

    public class Location
    {
        [JsonProperty("location-id")]
        public int locationId { get; set; }
        [JsonProperty("location-name")]
        public string locationName { get; set; }
        [JsonProperty("client-id")]
        public int clientId { get; set; }
        [JsonProperty("location-reference")]
        public string locationReference { get; set; }
    }
}
