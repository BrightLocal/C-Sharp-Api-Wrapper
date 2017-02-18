using Newtonsoft.Json;

namespace BrightLocal
{
    public class CitationBurstService : BlService
    {
        public CitationBurstService(string apiKey = null, string apiSecret = null) : base(apiKey, apiSecret) { }

        BlRequestor request = new BlRequestor();

        public virtual BlSuccess Create(CitationBurst create)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "create");
            var parameters = Parameters.convertListToParameters(create);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess Update(UpdateCitationBurst update)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", update.campaignId);
            var parameters = Parameters.convertListToParameters(update);
            var success = request.Put(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlSuccess UploadImage(CbUploadImage image)
        {
            var url = string.Format(Urls.CitationBurst + "{0}" + "/{1}", image.campaignId, image.imageType);
            var parameters = Parameters.convertListToParameters(image.file);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlCitations GetCitations(int campaignId)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "citations");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCitations>(success.Content);
        }

        public virtual BlSuccess ConfirmAndPay(BrightLocalCbPay pay)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "confirm-and-pay");
            var parameters = Parameters.convertListToParameters(pay);
            var success = request.Post(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(success.Content);
        }

        public virtual BlCbAllCampaigns GetCampaigns()
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCbAllCampaigns>(success.Content);
        }

        public virtual BlCbAllCampaigns GetCampaigns(int locationId)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "get-all");
            var parameters = new Parameters.requestParameters();
            parameters.Add("location-id", locationId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCbAllCampaigns>(success.Content);
        }

        public virtual BlCbCampaign GetCampaign(int campaignId)
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "get");
            var parameters = new Parameters.requestParameters();
            parameters.Add("campaign-id", campaignId);
            var success = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlCbCampaign>(success.Content);
        }

        public virtual BlSuccess GetCredits()
        {
            var url = string.Format(Urls.CitationBurst + "{0}", "credits");
            var parameters = new Parameters.requestParameters();
            
            var credits = request.Get(url, parameters, this.api_key, this.api_secret);
            return JsonConvert.DeserializeObject<BlSuccess>(credits.Content);
        }
    }
}
