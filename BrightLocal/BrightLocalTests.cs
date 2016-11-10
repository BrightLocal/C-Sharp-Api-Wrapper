using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrightLocal;
using Newtonsoft.Json;
[TestClass]
public class BrightLocalTests
{
    [TestMethod]
    public void apicreateTest()
    {
        // Arrange

        api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

        var parameters = new api.Parameters();
        parameters.Add("name", "Le Bernardin");
        parameters.Add("company-url", "http://www.example.com");
        parameters.Add("business-category-id", "791");

        // execute the request
        var success = request.Post("v1/clients-and-locations/clients/", parameters);
      
        //Verify
        Assert.AreEqual(HttpStatusCode.OK, success.StatusCode);
        Assert.IsTrue(success.ContentLength > 0);
        

    }
}
