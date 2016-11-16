using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Batches.examples
{
    public class batchExamples
    {
        public static IRestResponse addClient()
        {
            api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
            batchApi batchRequest = new batchApi(Api);           

            var success = batchRequest.Create();

            return success;
        }
    }
}
