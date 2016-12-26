using BrightLocal.Entities;
using BrightLocal.Services;
using BrightLocal.Services.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class clientExamples
    {
        public static BrightLocalClient Create()
        {
            var myClient = new ClientOptions();
            myClient.name = "Le Bernardin";
            myClient.companyUrl = "le-bernardin.com";
            myClient.businessCategoryId = 791;

            var clientService = new ClientService();

            BrightLocalClient newClient = clientService.Create(myClient);
            return newClient;
        }
    }
}
