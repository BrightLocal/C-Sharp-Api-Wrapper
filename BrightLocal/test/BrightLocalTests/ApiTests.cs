using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrightLocal;
using RestSharp;
using System.Net;
using Newtonsoft.Json;
using System.Reflection;

namespace BrightLocalTests
{
    // Simple test that tests the web request against BrightLocal api.
    // TODO: Add a mocking framework to simulate server responses
    
    [TestClass]
    public class ApiTests
    {
        [TestMethod]
        public void testRequest()
        {
            //arrange
            api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

            var parameters = new api.Parameters();
            parameters.Add("name", "Le Bernardin");
            parameters.Add("company-url", "http://www.example.com");
            parameters.Add("business-category-id", "791");

            //act
            var success = request.Post("v1/clients-and-locations/clients/", parameters);
            dynamic obj = JsonConvert.DeserializeObject(success.Content);
           
            //assert
            Assert.AreEqual(HttpStatusCode.OK, success.StatusCode);
            Assert.IsTrue(obj.success == "true");

        }
    }
}
