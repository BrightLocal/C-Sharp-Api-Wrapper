using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class batchApi
    {
        // Declare private variable
        private api Api;

        // Methods for creating, commiting, getting, deleting, stopping a batch request
        public IRestResponse Create()
        {
            Method method = Method.POST;
            var parameters = new api.Parameters();
            return this.Api.Call(method, "/v4/batch", parameters);
        }

        public IRestResponse Commit(string batchId)
        {
            Method method = Method.PUT;
            var parameters = new api.Parameters();
            parameters.Add("batch-id", batchId);
            return this.Api.Call(method, "/v4/batch", parameters);
        }

        public IRestResponse GetResults(string batchId)
        {
            Method method = Method.GET;
            var parameters = new api.Parameters();
            parameters.Add("batch-id", batchId);
            return this.Api.Call(method, "/v4/batch", parameters);
        }

        public IRestResponse Delete(string batchId)
        {
            Method method = Method.DELETE;
            var parameters = new api.Parameters();
            parameters.Add("batch-id", batchId);
            return this.Api.Call(method, "/v4/batch", parameters);
        }

        public IRestResponse Stop(string batchId)
        {
            Method method = Method.PUT;
            var parameters = new api.Parameters();
            parameters.Add("batch-id", batchId);
            return this.Api.Call(method, "/v4/batch/stop", parameters);
        }

        //batchApi class contructor
        public batchApi(api Api)
        {
            this.Api = Api;
        }
    }
}
