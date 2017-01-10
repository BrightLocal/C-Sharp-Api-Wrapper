using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalCitationTrackerResults
    {
        public CtResponse response { get; set; }        
    }

    public class CtResponse
    {
        public CtResults results { get; set; }
    }

    public class CtResults
    {
        public List<Active> active { get; set; }
        
        [JsonProperty("possible")]
        public PossibleCitations possible { get; set; }
        public List<object> pending { get; set; }
        public Domains activeDomains { get; set; }
        public List<object> pendingDomains { get; set; }
        public Dictionary<string, string> possibleDomains { get; set; }
        public List<TopDirectory> topDirectories { get; set; }
        public Flags flags { get; set; }
        public List<Competitors> competitors { get; set; }
        public CtUrls urls { get; set; }
    }

    public class Active
    {
        public string id { get; set; }
        public string citation_id { get; set; }
        public string customer_id { get; set; }
        public string report_id { get; set; }
        [JsonProperty("citation-status")]
        public string citationStatus { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        [JsonProperty("citation-notes")]
        public string citationNotes { get; set; }
        public object status_smile { get; set; }
        public object need_to_fix { get; set; }
        public string status { get; set; }
        [JsonProperty("date-identified-sorting")]
        public string dateIdentifiedSorting { get; set; }
        [JsonProperty("date-identified")]
        public string dateIdentified { get; set; }
        [JsonProperty("domain-authority")]
        public string domainAuthority { get; set; }
        [JsonProperty("citation-value")]
        public string citationValue { get; set; }
        [JsonProperty("moz-rank")]
        public string mozRank { get; set; }
        [JsonProperty("site-type")]
        public string siteType { get; set; }
        [JsonProperty("listing-type")]
        public string listingType { get; set; }
        [JsonProperty("seomoz-lookup-complete")]
        public string seomozLookupComplete { get; set; }
        [JsonProperty("business-name")]
        public string businessName { get; set; }
        public string postcode { get; set; }
    }
   
    public class PossibleCitations : Dictionary<string, Possible>
    {

    }

    public class Possible
    {
        public string id { get; set; }
        public string citation_id { get; set; }
        public string customer_id { get; set; }
        public string report_id { get; set; }
        [JsonProperty("citation-status")]
        public string citationStatus { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        [JsonProperty("citation-notes")]
        public string citationNotes { get; set; }
        public string status_smile { get; set; }
        public string need_to_fix { get; set; }
        public string status { get; set; }
        [JsonProperty("date-identified-sorting")]
        public string dateIdentifiedSorting { get; set; }
        [JsonProperty("date-identified")]
        public string dateIdentified { get; set; }
        [JsonProperty("domain-authority")]
        public string domainAuthority { get; set; }
        [JsonProperty("citation-value")]
        public string citationValue { get; set; }
        [JsonProperty("moz-rank")]
        public string mozRank { get; set; }
        [JsonProperty("site-type")]
        public string siteType { get; set; }
        [JsonProperty("listing-type")]
        public string listingType { get; set; }
        [JsonProperty("seomoz-lookup-complete")]
        public string seomozLookupComplete { get; set; }
        [JsonProperty("business-name")]
        public string businessName { get; set; }
        [JsonProperty("is-citation-burst-available")]
        public bool isCitationBurstAvailable { get; set; }
        [JsonProperty("get-citation-url")]
        public string getCitationUrl { get; set; }
    }

    
    public class Domains : Dictionary<string, string>
    {

    }

    public class TopDirectory
    {
        public string citation_id { get; set; }
        public string customer_id { get; set; }
        public string report_id { get; set; }
        [JsonProperty("citation-status")]
        public string citationStatus { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        [JsonProperty("citation-notes")]
        public string citationNotes { get; set; }
        public string status_smile { get; set; }
        public string need_to_fix { get; set; }
        public string status { get; set; }
        public string dateIdentifiedSorting { get; set; }
        [JsonProperty("date-identified")]
        public string dateIdentified { get; set; }
        [JsonProperty("domain-authority")]
        public string domainAuthority { get; set; }
        [JsonProperty("citation-value")]
        public string citationValue { get; set; }
        [JsonProperty("moz-rank")]
        public string mozRank { get; set; }
        [JsonProperty("site-type")]
        public string siteType { get; set; }
        [JsonProperty("listing-type")]
        public string listingType { get; set; }
        [JsonProperty("seomoz-lookup-complete")]
        public string seomozLookupComplete { get; set; }
        [JsonProperty("business-name")]
        public string businessName { get; set; }
        public string address { get; set; }
        public string postcode { get; set; }
        public string telephone { get; set; }
    }

    public class Flags
    {
        public Customer customer { get; set; }
        public Competitor competitor { get; set; }
    }

    public class Customer
    {
        public List<string> @new { get; set; }
        public List<string> disappeared { get; set; }
    }

    public class Competitor
    {
        public List<string> @new { get; set; }
        public List<string> disappeared { get; set; }
    }

    public class Competitors
    {
        public string business_name { get; set; }
        public Domains domains { get; set; }
    }
    
}
