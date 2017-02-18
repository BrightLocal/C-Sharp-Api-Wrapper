using System;
using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class clientExamples
    {
        public static BlSuccess Create()
        {
            var myClient = new ClientOptions();
            myClient.name = "Le Bernardin";
            myClient.companyUrl = "le-bernardin.com";
            myClient.businessCategoryId = 791;

            var clientService = new ClientService();

            BlSuccess newClient = clientService.Create(myClient);
            return newClient;
        }

        public static BlSuccess Update()
        {
            var myClient = new UpdateClientOptions();
            myClient.clientId = 36447;
            myClient.name = "Le Bernardin";
            myClient.companyUrl = "le-bernardin.com";
            myClient.businessCategoryId = 791;

            var clientService = new ClientService();

            BlSuccess updateClient = clientService.Update(myClient);
            return updateClient;
        }

        public static BlSuccess Delete()
        {
            var clientId = 1;
            var clientService = new ClientService();

            BlSuccess deleteClient = clientService.Delete(clientId);
            return deleteClient;
        }

        public static BlClient Get()
        {
            var clientId = 1;
            var clientService = new ClientService();

            BlClient client = clientService.Get(clientId);
            return client;
        }

        public static BlClientSearch Search()
        {
            var searchQuery = "le-bernardin";
            var clientService = new ClientService();

            BlClientSearch results = clientService.Search(searchQuery);
            return results;
        }
    }
}
