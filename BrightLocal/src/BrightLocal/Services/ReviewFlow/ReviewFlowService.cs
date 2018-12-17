using Newtonsoft.Json;

namespace BrightLocal
{
    public class ReviewFlowService : BlService
    {
        public ReviewFlowService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(ReviewFlow create)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", "add");
            var parameters = Parameters.convertListToParameters(create);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateReviewFlow update)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", update.reportId);
            var parameters = Parameters.convertListToParameters(update);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlRfReport Get(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlRfReport>(success.Content);
        }

        public virtual BlSuccess Delete(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Delete(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlRfGetAll GetAll()
        {
            var url = string.Format(Urls.ReviewFlow);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlRfGetAll>(success.Content);
        }

        public virtual BlRfGetAll GetAll(int locationId)
        {
            var url = string.Format(Urls.ReviewFlow);
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlRfGetAll>(success.Content);
        }

        public virtual BlRfGetAll Search(string query)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}", "search");
            var parameters = new Parameters.requestParameters();
            parameters.Add("q", query);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlRfGetAll>(success.Content);
        }

        public virtual BlRfReviews GetReviews(RfGetReviews getReviews)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/reviews", getReviews.reportId);
            var parameters = Parameters.convertListToParameters(getReviews);            
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlRfReviews>(success.Content);
        }

        public virtual BlSuccess GetReviewCount(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/reviews/count", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess GetGrowth(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/reviews/growth", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlRfDirectories GetDirectories(int reportId)
        {
            var url = string.Format(Urls.ReviewFlow + "{0}" + "/directories", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlRfDirectories>(success.Content);
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
