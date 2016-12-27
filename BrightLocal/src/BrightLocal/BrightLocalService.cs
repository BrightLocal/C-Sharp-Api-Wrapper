namespace BrightLocal
{
    public class BrightLocalService
    {
        // Decalre Variables
        public string api_key;
        public string api_secret;

        protected  BrightLocalService(string apiKey, string apiSecret)
        {
            api_key = apiKey;
            api_secret = apiSecret;
        }
    }
}
