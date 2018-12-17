namespace BrightLocal
{
    public class BlService
    {
        // Decalre Variables
        public string api_key;
        public string api_secret;

        protected  BlService(string apiKey, string apiSecret)
        {
            api_key = apiKey;
            api_secret = apiSecret;
        }
    }
}
