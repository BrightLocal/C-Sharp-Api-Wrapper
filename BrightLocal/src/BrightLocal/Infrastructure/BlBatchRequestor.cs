using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlBatchRequestor
    {
        private static readonly System.Uri baseUrl = new System.Uri(Urls.BaseUrl);
        private static readonly string url = "/v4/batch";
        // create an instance of restsharp client
        RestClient client = new RestClient();

        public int Create(string apiKey)
        {
            Method method = Method.POST;
            var parameters = new Parameters.requestParameters();
            var response = this.Call(method, apiKey, parameters);
            dynamic obj = JsonConvert.DeserializeObject(response.Content);
            if (obj.success != "true")
            {
                const string message = "Error creating Batch ";
                var batchException = new ApplicationException(message + obj.errors, obj.ErrorException);
                throw batchException;
            }
            return obj["batch-id"];
        }

        public IRestResponse Commit(int batchId, string apiKey)
        {
            Method method = Method.PUT;
            var parameters = new Parameters.requestParameters();
            parameters.Add("batch-id", batchId);
            var request = this.Call(method, apiKey, parameters);
            
            return request;
        }

        public IRestResponse GetResults(int batchId, string apiKey)
        {
            Method method = Method.GET;
            var parameters = new Parameters.requestParameters();
            parameters.Add("batch-id", batchId);
            var results = this.Call(method, apiKey, parameters);

            return results;
        }

        public IRestResponse Call(Method method, string apiKey, Parameters.requestParameters apiParameters)
        {
            apiKey = apiKey ?? BlConfiguration.GetApiKey();
            
            // create sxpires variable
            
            // set base url   
            client.BaseUrl = baseUrl;
            // Generate encoded signature
            
            // Generate the request
            var request = GetApiRequest(method, apiKey, apiParameters);
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

        private static RestRequest GetApiRequest(Method method, string api_key, Parameters.requestParameters apiParameters)
        {
            // Create a new restsharp request
            RestRequest request = new RestRequest(url, method);
            // Add appropriate headers to request
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            // Add key, sig and expires to request
            request.AddParameter("api-key", api_key);
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
