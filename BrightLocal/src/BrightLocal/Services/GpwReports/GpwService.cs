
using Newtonsoft.Json;

namespace BrightLocal
{
    public class GpwService : BlService
    {
        public GpwService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(Gpw create)
        {
            var url = string.Format(Urls.Gpw + "{0}", "add");
            var parameters = Parameters.convertListToParameters(create);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateGpw update)
        {
            var url = string.Format(Urls.Gpw + "{0}", update.reportId);
            var parameters = Parameters.convertListToParameters(update);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlGpwReport Get(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlGpwReport>(success.Content);
        }

        public virtual BlSuccess Delete(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", reportId);
            var parameters = new Parameters.requestParameters();
            var success = request.Delete(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlGpwGetAllResults GetAll()
        {
            var parameters = new Parameters.requestParameters();
            var success = request.Get(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlGpwGetAllResults>(success.Content);
        }

        public virtual BlGpwGetAllResults GetAll(int locationId)
        {
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Get(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlGpwGetAllResults>(success.Content);
        }

        public virtual BlSuccess Run(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", "run");
            var parameters = new Parameters.requestParameters();
            parameters.Add("report-id", reportId);
            var success = request.Put(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlGpwReportResults GetReportResults(int reportId)
        {
            var url = string.Format(Urls.Gpw + "{0}", reportId + "/results");
            var parameters = new Parameters.requestParameters();            
            var success = request.Get(Urls.Gpw, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlGpwReportResults>(success.Content);
        }
    }
}
