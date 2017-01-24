using Newtonsoft.Json;

namespace BrightLocal
{
    public class CitationBurstService : BrightLocalService
    {
        public CitationBurstService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BrightLocalRequestor request = new BrightLocalRequestor();

        public virtual BrightLocalSuccess Create(CitationBurstOptions createOptions)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "create");
            var parameters = Parameters.convertListToParameters(createOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess Update(UpdateCitationBurstOptions updateOptions)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", updateOptions.campaignId);
            var parameters = Parameters.convertListToParameters(updateOptions);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalSuccess UploadImage(CbUploadImage imageOptions)
        {
            var url = string.Format(Urls.CitationBurst + "{0}" + "/{1}", imageOptions.campaignId, imageOptions.imageType);
            var parameters = Parameters.convertListToParameters(imageOptions.file);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalCitations GetCitations(int campaignId)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "citations");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCitations>(success.Content);
        }

        public virtual BrightLocalSuccess ConfirmAndPay(BrightLocalCbPayOptions payOptions)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "confirm-and-pay");
            var parameters = Parameters.convertListToParameters(payOptions);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(success.Content);
        }

        public virtual BrightLocalCbAllCampaigns GetCampaigns()
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCbAllCampaigns>(success.Content);
        }

        public virtual BrightLocalCbAllCampaigns GetCampaigns(int locationId)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCbAllCampaigns>(success.Content);
        }

        public virtual BrightLocalCbCampaign GetCampaign(int campaignId)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalCbCampaign>(success.Content);
        }

        public virtual BrightLocalSuccess GetCredits()
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "credits");
            var parameters = new Parameters.requestParameters();
            
            var credits = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BrightLocalSuccess>(credits.Content);
        }
    }
}
