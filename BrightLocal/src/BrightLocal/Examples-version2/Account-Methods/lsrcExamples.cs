using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class lsrcExamples
    {
        public static BlSuccess Create()
        {
            var lsrc = new LsrcOptions();
            lsrc.name = "Le Bernardin";
            lsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() {"le-bernardin.com", "www.le-bernadin.com"});
            lsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
            lsrc.schedule = "Adhoc";
            lsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";
          
            var lsrcService = new LsrcService();

            BlSuccess newLsrc = lsrcService.Create(lsrc);
            return newLsrc;
        }

        public static BlSuccess Update()
        {
            var lsrc = new UpdateLsrcOptions();
            lsrc.campaignId = 1;
            lsrc.name = "Le Bernardin";
            lsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() { "le-bernardin.com", "www.le-bernadin.com" });
            lsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
            lsrc.schedule = "Adhoc";
            lsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";

            var lsrcService = new LsrcService();

            BlSuccess updatedLsrc = lsrcService.Update(lsrc);
            return updatedLsrc;
        }

        public static BlSuccess Delete()
        {
            var campaignId = 1;           
            var lsrcService = new LsrcService();

            BlSuccess deletedLsrc = lsrcService.Delete(campaignId);
            return deletedLsrc;
        }

        public static BlGetAllResults GetAll()
        {
            var lsrcService = new LsrcService();

            BlGetAllResults lsrcList = lsrcService.GetAll();
            return lsrcList;
        }

        public static BlLsrcReport GetReport()
        {
            var campaignId = 1;
            var lsrcService = new LsrcService();

            BlLsrcReport lsrc = lsrcService.Get(campaignId);
            return lsrc;
        }

        public static BlSuccess Run()
        {
            var campaignId = 1;
            var lsrcService = new LsrcService();

            BlSuccess lsrc = lsrcService.Run(campaignId);
            return lsrc;
        }

        public static BlLsrcHistory GetHistory()
        {
            var campaignId = 1;
            var lsrcService = new LsrcService();

            BlLsrcHistory lsrcHistory = lsrcService.GetHistory(campaignId);
            return lsrcHistory;
        }

        public static BlLsrcReportResults GetReportResults()
        {
            var lsrc = new GetResultsLsrcOptions();
            lsrc.campaignId = 1;
            
            var lsrcService = new LsrcService();

            var lsrcResults = lsrcService.GetResults(lsrc);
            return lsrcResults;
        }
    }
}
