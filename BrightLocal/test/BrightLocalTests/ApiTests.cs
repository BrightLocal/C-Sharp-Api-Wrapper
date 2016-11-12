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
            //api request = new api("1a08b2e1fd07fa4150f91b80636906a9a29b8e47", "57645cb550c37");
            var parameters = new api.Parameters();
            parameters.Add("report_name", "Sample SEO Check-Up Report");
            parameters.Add("business_names", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("day_of_month", "2");
            parameters.Add("report_type", "with");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state_code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("phone_number", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("search_terms", "['restaurant manhattan', 'cafe new york']");

            //act
            var success = request.Post("v4/gpw/add", parameters);
            dynamic obj = JsonConvert.DeserializeObject(success.Content);
           
            //assert
            Assert.AreEqual(HttpStatusCode.OK, success.StatusCode);
            Assert.IsTrue(obj.success == "true");

        }
    }
}
