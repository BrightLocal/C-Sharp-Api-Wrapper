using Newtonsoft.Json;

namespace BrightLocal
{
    public class ReviewFlowService : BrightLocalService
    {
        public ReviewFlowService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalSuccess Create(ReviewFlowOptions createOptions)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", "add");
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Update(UpdateReviewFlowOptions updateOptions)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", updateOptions.reportId);
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalRfReport Get(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfReport>(success.Content);
        }

        public virtual BrightLocalSuccess Delete(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Delete(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalRfGetAll GetAll()
        {
            var url = string.Format(Urls.ReviewFlow);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfGetAll>(success.Content);
        }

        public virtual BrightLocalRfGetAll GetAll(int locationId)
        {
            var url = string.Format(Urls.ReviewFlow);
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfGetAll>(success.Content);
        }

        public virtual BrightLocalRfGetAll Search(string query)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfGetAll>(success.Content);
        }

        public virtual BrightLocalRfReviews GetReviews(RfGetReviewsOptions getReviews)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/reviews", getReviews.reportId);
            var parameters = Parameters.convertListToParameters(getReviews);            
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfReviews>(success.Content);
        }

        public virtual BrightLocalSuccess GetReviewCount(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/reviews/count", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess GetGrowth(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/reviews/growth", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalRfDirectories GetDirectories(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/directories", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfDirectories>(success.Content);
        }

        public virtual BrightLocalRfDirectoryStats GetDirectoryStats(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/directories/stats", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfDirectoryStats>(success.Content);
        }

        public virtual BrightLocalRfStarCounts GetStarCount(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/stars/count", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalRfStarCounts>(success.Content);
        }
    }
}
