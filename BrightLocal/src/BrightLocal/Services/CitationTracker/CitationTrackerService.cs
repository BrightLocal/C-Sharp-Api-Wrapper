using Newtonsoft.Json;

namespace BrightLocal
{
    public class CitationTrackerService: BrightLocalService
    {
        public CitationTrackerService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalSuccess Create(CitationTrackerOptions createOptions)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "add");
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Update(UpdateCitationTrackerOptions updateOptions)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "update");
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalCitationTrackerReport Get(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCitationTrackerReport>(success.Content);
        }

        public virtual BrightLocalSuccess Run(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Delete(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "delete");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        //method overlaod for supplying the location-id parameter
        public virtual BrightLocalCtGetAllResults GetAll(int locationId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCtGetAllResults>(success.Content);
        }

        public virtual BrightLocalCtGetAllResults GetAll()
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();            
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCtGetAllResults>(success.Content);
        }
        public virtual BrightLocalCitationTrackerResults GetReportResults(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get-results");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCitationTrackerResults>(success.Content);
        }
    }
}
