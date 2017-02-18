using System;
using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class clientExamples
    {
        public static BlSuccess Create()
        {
            var client = new ClientOptions();
            client.name = "Le Bernardin";
            client.companyUrl = "le-bernardin.com";
            client.businessCategoryId = 791;

            var clientService = new ClientService();

            BlSuccess newClient = clientService.Create(client);
            return newClient;
        }

        public static BlSuccess Update()
        {
            var client = new UpdateClientOptions();
            client.clientId = 36447;
            client.name = "Le Bernardin";
            client.companyUrl = "le-bernardin.com";
            client.businessCategoryId = 791;

            var clientService = new ClientService();

            BlSuccess updateClient = clientService.Update(client);
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
