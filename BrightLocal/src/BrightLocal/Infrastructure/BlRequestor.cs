using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlRequestor
    {
        private static readonly System.Uri baseUrl = new System.Uri(Urls.BaseUrl);
       
        // create an instance of restsharp client
        RestClient client = new RestClient();


        // Create base 64 sha1 encrypted signature
        private static string CreateSig(string apiKey, string secretKey, double expires)
        {
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secretKey);
            byte[] messageBytes = encoding.GetBytes(apiKey + expires);
            using (var hmacsha1 = new HMACSHA1(keyByte))
            {
                byte[] hashmessage = hmacsha1.ComputeHash(messageBytes);
                var signature = Convert.ToBase64String(hashmessage);
                var sig = HttpUtility.UrlEncode(signature);
                return signature;
            }

        }

        // Create expires paramater for signature and api requests
        private static double CreateExpiresParameter()
        {
            DateTime date = DateTime.Now;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc); // The seconds since the Unix Epoch (January 1 1970 00:00:00 GMT)
            TimeSpan diff = date.ToUniversalTime() - origin;  // Subtract the seconds since the Unix Epoch from today's date. 
            return Math.Floor(diff.TotalSeconds + 1800); // Not more than 1800 seconds
        }


        // Function that creates and sends the actual request.
        public IRestResponse Call(Method method, string endPoint, Dictionary<string, object> apiParameters, string apiKey, string apiSecret)
        {
            apiKey = apiKey ?? BlConfiguration.GetApiKey();
            apiSecret = apiSecret ?? BlConfiguration.GetApiSecret();
            // create sxpires variable
            var expires = CreateExpiresParameter();
            // set base url   
            client.BaseUrl = baseUrl;
            // Generate encoded signature
            var sig = CreateSig(apiKey, apiSecret, expires);
            // Generate the request
            var request = GetApiRequest(method, endPoint, apiKey, sig, expires, apiParameters);
            // execure the request
            var response = client.Execute(request);
            // check for a succesful response from server
            if (response.ResponseStatus == ResponseStatus.Completed)
            {               
                dynamic result = JsonConvert.DeserializeObject(response.Content);
                if (result.success == "false")
                {
                    string message = "Error: ";
                    var batchException = new ApplicationException(message + result.errors, result.ErrorException);
                    throw batchException;
                }
                return response;
            }
            else
            {
                throw new ApplicationException(response.ErrorMessage);
            }
            
        }

        // Methods for post, put, get, delete
        public IRestResponse Post(string endPoint, Dictionary<string, object> apiParameters, string apiKey, string apiSecret)
        {
            Method method = Method.POST;
            return Call(method, endPoint, apiParameters, apiKey, apiSecret);
        }

        public IRestResponse Put(string endPoint, Dictionary<string, object> apiParameters, string apiKey, string apiSecret)
        {
            Method method = Method.PUT;
            return Call(method, endPoint, apiParameters, apiKey, apiSecret);
        }

        public IRestResponse Get(string endPoint, Dictionary<string, object> apiParameters, string apiKey, string apiSecret)
        {
            Method method = Method.GET;
            return Call(method, endPoint, apiParameters, apiKey, apiSecret);
        }

        public IRestResponse Delete(string endPoint, Dictionary<string, object> apiParameters, string apiKey, string apiSecret)
        {
            Method method = Method.DELETE;
            return Call(method, endPoint, apiParameters, apiKey, apiSecret);
        }
       
        private static RestRequest GetApiRequest(Method method, string url, string api_key, string sig, double expires, Dictionary<string, object> apiParameters)
        {
            // Create a new restsharp request
            RestRequest request = new RestRequest(url, method);
            // Add appropriate headers to request
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            // Add key, sig and expires to request
            request.AddParameter("api-key", api_key);
            request.AddParameter("sig", sig);
            request.AddParameter("expires", expires);

            // Loop through the parameters passed in as a dictionary and add each one to a dynamic object
            var eo = new ExpandoObject();
            var eoColl = (ICollection<KeyValuePair<string, object>>)eo;
            foreach (var kvp in apiParameters)
            {
                eoColl.Add(kvp);
            }
            dynamic eoDynamic = eo;

            // Add each parameter to restsharp request
            foreach (var prop in eoDynamic)
            {
                request.AddParameter(prop.Key, prop.Value);
            }

            return request;

        }

    }
}
