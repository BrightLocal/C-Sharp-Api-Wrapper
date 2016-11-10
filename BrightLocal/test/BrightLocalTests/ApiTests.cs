using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrightLocal;
using RestSharp;
using System.Net;

namespace BrightLocalTests
{
    [TestClass]
    public class ApiTests
    {
        [TestMethod]
        public void testRequest()
        {
            //arrange
            api request = new api("1a08b2e1fd07fa4150f91b80636906a9a29b8e47", "57645cb550c37");
            
            var parameters = new api.Parameters();
            parameters.Add("name", "Le Bernardin");
            parameters.Add("company-url", "http://www.example.com");
            parameters.Add("business-category-id", "791");

            //act
            var success = request.Post("v1/clients-and-locations/clients/", parameters);

            //assert
            Assert.AreEqual(HttpStatusCode.OK, success.StatusCode);
            
        }

        [TestMethod]
        public void testCreateExpires()
        {
            //arrange
            api request = new api("1a08b2e1fd07fa4150f91b80636906a9a29b8e47", "57645cb550c37");

            var parameters = new api.Parameters();
            parameters.Add("name", "Le Bernardin");
            parameters.Add("company-url", "http://www.example.com");
            parameters.Add("business-category-id", "791");

            //act
            var success = request.Post("v1/clients-and-locations/clients/", parameters);

            //assert
            Assert.AreEqual(HttpStatusCode.OK, success.StatusCode);

        }

    }
}
