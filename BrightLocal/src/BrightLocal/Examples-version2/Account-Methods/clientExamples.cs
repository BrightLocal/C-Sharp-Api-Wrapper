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

        public static BrightLocalClient Update()
        {
            var myClient = new UpdateClientOptions();
            myClient.clientId = 36447;
            myClient.name = "Le Bernardin";
            myClient.companyUrl = "le-bernardin.com";
            myClient.businessCategoryId = 791;

            var clientService = new ClientService();

            BrightLocalClient updateClient = clientService.Update(myClient);
            return updateClient;
        }

        public static BrightLocalClient Delete()
        {
            var clientId = 1;
            var clientService = new ClientService();

            BrightLocalClient deleteClient = clientService.Delete(clientId);
            return deleteClient;
        }

        public static BrightLocalClient Get()
        {
            var clientId = 1;
            var clientService = new ClientService();

            BrightLocalClient client = clientService.Get(clientId);
            return client;
        }

        public static List<BrightLocalClient> Search()
        {
            var searchQuery = "le-bernardin";
            var clientService = new ClientService();

            List<BrightLocalClient> results = clientService.Search(searchQuery);
            return results;
        }
    }
}
