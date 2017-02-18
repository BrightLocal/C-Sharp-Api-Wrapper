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
            LscuOptions lscu = new LscuOptions();
            lscu.reportName = "Sample SEO Chek-Up Report";
            lscu.businessNames = JsonConvert.SerializeObject(new List<string>() {"Le Bernardin", "Le Bernardin Cafe"});
            lscu.websiteAddress = "le-bernardin.com";
            lscu.address1 = "155 Weest 51st Street";
            lscu.address2 = "";
            lscu.city = "New York";
            lscu.stateCode = "NY";
            lscu.postcode = "10019";
            lscu.telephone = "+1 212-554-1515";
            lscu.country = "USA";
            lscu.businessCategory = "Restaurant";
            lscu.primaryBusinessLocation = "NY, New York";
            lscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });


            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            lscu.localDirectoryUrls = new LocalDirectoryUrls();
            lscu.localDirectoryUrls.Add(
                "citysearch",
                new DirectoryUrls
                {
                    url = null,
                    include = "yes"
                });
            lscu.localDirectoryUrls.Add(
                "dexknows",
                new DirectoryUrls
                {
                    url = null,
                    include = "yes"
                });

            var lscuService = new LscuService();

            BlSuccess newLscu = lscuService.Create(lscu);

            return newLscu;
        }

        public static BlSuccess Update()
        {
            UpdateLscuOptions lscu = new UpdateLscuOptions();
            lscu.reportId = 1;
            lscu.reportName = "Sample SEO Chek-Up Report";
            lscu.businessNames = JsonConvert.SerializeObject(new List<string>() { "Le Bernardin", "Le Bernardin Cafe" });
            lscu.websiteAddress = "le-bernardin.com";
            lscu.address1 = "155 Weest 51st Street";
            lscu.address2 = "";
            lscu.city = "New York";
            lscu.stateCode = "NY";
            lscu.postcode = "10019";
            lscu.telephone = "+1 212-554-1515";
            lscu.country = "USA";
            lscu.businessCategory = "Restaurant";
            lscu.primaryBusinessLocation = "NY, New York";
            lscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

            var lscuService = new LscuService();

            BlSuccess updateLscu = lscuService.Update(lscu);

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
