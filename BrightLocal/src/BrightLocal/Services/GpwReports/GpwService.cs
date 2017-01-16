
using Newtonsoft.Json;

namespace BrightLocal
{
    public class GpwService : BrightLocalService
    {
        public GpwService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalSuccess Create(GpwOptions createOptions)
        {
            var url = string.Format(Urls.Gpw + "{0}", "add");
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Update(UpdateGpwOptions updateOptions)
        {
            var url = string.Format(Urls.Gpw + "{0}", updateOptions.reportId);
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalGpwReport Get(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalGpwReport>(success.Content);
        }

        public virtual BrightLocalSuccess Delete(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Delete(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalGpwGetAllResults GetAll()
        {
            var parameters = new Parameters.requestParameters();
            var success = request.Get(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalGpwGetAllResults>(success.Content);
        }

        public virtual BrightLocalGpwGetAllResults GetAll(int locationId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Get(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalGpwGetAllResults>(success.Content);
        }

        public virtual BrightLocalSuccess Run(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Put(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalGpwReportResults GetReportResults(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", reportId + "/results");
            var parameters = new Parameters.requestParameters();            
            var success = request.Get(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalGpwReportResults>(success.Content);
        }
    }
}
