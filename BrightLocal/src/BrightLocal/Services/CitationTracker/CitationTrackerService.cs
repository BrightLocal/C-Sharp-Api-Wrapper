using Newtonsoft.Json;

namespace BrightLocal
{
    public class CitationTrackerService: BlService
    {
        public CitationTrackerService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(CitationTrackerOptions createOptions)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "add");
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateCitationTrackerOptions updateOptions)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "update");
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlCitationTrackerReport Get(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCitationTrackerReport>(success.Content);
        }

        public virtual BlSuccess Run(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Delete(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "delete");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        //method overlaod for supplying the location-id parameter
        public virtual BlCtGetAllResults GetAll(int locationId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCtGetAllResults>(success.Content);
        }

        public virtual BlCtGetAllResults GetAll()
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();            
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCtGetAllResults>(success.Content);
        }
        public virtual BlCitationTrackerResults GetReportResults(int reportId)
        {
            var url = string.Format(Urls.CitationTracker + "{0}", "get-results");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCitationTrackerResults>(success.Content);
        }
    }
}
