using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class lscuExamples
    {
        public static BrightLocalSuccess Create()
        {
            LscuOptions myLscu = new LscuOptions();
            myLscu.reportName = "Sample SEO Chek-Up Report";
            myLscu.businessNames = new List<string>() {"Le Bernardin", "Le Bernardin Cafe"};
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
            myLscu.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };


            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            myLscu.localDirectoryUrls = new LocalDirectoryUrls();
            myLscu.localDirectoryUrls.Add(
                "citysearch",
                new DirectoryUrls
                {
                    url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
                    include = "yes"
                });
            myLscu.localDirectoryUrls.Add(
                "dexknows",
                new DirectoryUrls
                {
                    url = "",
                    include = "yes"
                });

            var lscuService = new LscuService();

            BrightLocalSuccess newLscu = lscuService.Create(myLscu);

            return newLscu;
        }

        public static BrightLocalSuccess Update()
        {
            UpdateLscuOptions myLscu = new UpdateLscuOptions();
            myLscu.reportId = 1;
            myLscu.reportName = "Sample SEO Chek-Up Report";
            myLscu.businessNames = new List<string>() { "Le Bernardin", "Le Bernardin Cafe" };
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
            myLscu.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };

            var lscuService = new LscuService();

            BrightLocalSuccess updateLscu = lscuService.Update(myLscu);

            return updateLscu;
        }

        public static BrightLocalLscuReport Get()
        {
            var reportId = 1;
            var lscuService = new LscuService();

            BrightLocalLscuReport lscuReport = lscuService.Get(reportId);
            return lscuReport;

        }

        public static string Run()
        {
            var reportId = 1;
            var lscuService = new LscuService();

            var success = lscuService.Run(reportId);
            return success;
        }

        public static string Delete()
        {
            var reportId = 1;
            var lscuService = new LscuService();

            var success = lscuService.Delete(reportId);
            return success;
        }

        public static BrightLocalLscuSearch Search()
        {
            var searchQuery = "Bodega Wine Bar";
            var lscuService = new LscuService();

            BrightLocalLscuSearch lscuSearch = lscuService.Search(searchQuery);
            return lscuSearch;
        }
    }
}
