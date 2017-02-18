using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class lscuExamples
    {
        public static BlSuccess Create()
        {
            LscuOptions myLscu = new LscuOptions();
            myLscu.reportName = "Sample SEO Chek-Up Report";
            myLscu.businessNames = JsonConvert.SerializeObject(new List<string>() {"Le Bernardin", "Le Bernardin Cafe"});
            myLscu.websiteAddress = "le-bernardin.com";
            myLscu.address1 = "155 Weest 51st Street";
            myLscu.address2 = "";
            myLscu.city = "New York";
            myLscu.stateCode = "NY";
            myLscu.postcode = "10019";
            myLscu.telephone = "+1 212-554-1515";
            myLscu.country = "USA";
            myLscu.businessCategory = "Restaurant";
            myLscu.primaryBusinessLocation = "NY, New York";
            myLscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });


            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            myLscu.localDirectoryUrls = new LocalDirectoryUrls();
            myLscu.localDirectoryUrls.Add(
                "citysearch",
                new DirectoryUrls
                {
                    url = null,
                    include = "yes"
                });
            myLscu.localDirectoryUrls.Add(
                "dexknows",
                new DirectoryUrls
                {
                    url = null,
                    include = "yes"
                });

            var lscuService = new LscuService();

            BlSuccess newLscu = lscuService.Create(myLscu);

            return newLscu;
        }

        public static BlSuccess Update()
        {
            UpdateLscuOptions myLscu = new UpdateLscuOptions();
            myLscu.reportId = 1;
            myLscu.reportName = "Sample SEO Chek-Up Report";
            myLscu.businessNames = JsonConvert.SerializeObject(new List<string>() { "Le Bernardin", "Le Bernardin Cafe" });
            myLscu.websiteAddress = "le-bernardin.com";
            myLscu.address1 = "155 Weest 51st Street";
            myLscu.address2 = "";
            myLscu.city = "New York";
            myLscu.stateCode = "NY";
            myLscu.postcode = "10019";
            myLscu.telephone = "+1 212-554-1515";
            myLscu.country = "USA";
            myLscu.businessCategory = "Restaurant";
            myLscu.primaryBusinessLocation = "NY, New York";
            myLscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

            var lscuService = new LscuService();

            BlSuccess updateLscu = lscuService.Update(myLscu);

            return updateLscu;
        }

        public static BlLscuReport Get()
        {
            var reportId = 1;
            var lscuService = new LscuService();

            BlLscuReport lscuReport = lscuService.Get(reportId);
            return lscuReport;

        }

        public static BlSuccess Run()
        {
            var reportId = 1;
            var lscuService = new LscuService();

            var success = lscuService.Run(reportId);
            return success;
        }

        public static BlSuccess Delete()
        {
            var reportId = 1;
            var lscuService = new LscuService();

            var success = lscuService.Delete(reportId);
            return success;
        }

        public static BlLscuSearch Search()
        {
            var searchQuery = "Bodega Wine Bar";
            var lscuService = new LscuService();

            BlLscuSearch lscuSearch = lscuService.Search(searchQuery);
            return lscuSearch;
        }
    }
}
