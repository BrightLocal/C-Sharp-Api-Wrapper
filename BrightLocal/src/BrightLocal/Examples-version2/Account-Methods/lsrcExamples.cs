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
            var myLsrc = new LsrcOptions();
            myLsrc.name = "Le Bernardin";
            myLsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() {"le-bernardin.com", "www.le-bernadin.com"});
            myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
            myLsrc.schedule = "Adhoc";
            myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";
          
            var lsrcService = new LsrcService();

            BlSuccess newLsrc = lsrcService.Create(myLsrc);
            return newLsrc;
        }

        public static BlSuccess Update()
        {
            var myLsrc = new UpdateLsrcOptions();
            myLsrc.campaignId = 1;
            myLsrc.name = "Le Bernardin";
            myLsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() { "le-bernardin.com", "www.le-bernadin.com" });
            myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
            myLsrc.schedule = "Adhoc";
            myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";

            var lsrcService = new LsrcService();

            BlSuccess updatedLsrc = lsrcService.Update(myLsrc);
            return updatedLsrc;
        }

        public static BlSuccess Delete()
        {
            var campaignId = 1;           
            var lsrcService = new LsrcService();

            BlSuccess deletedLsrc = lsrcService.Delete(campaignId);
            return deletedLsrc;
        }

        public static BrightLocalGetAllResults GetAll()
        {
            var lsrcService = new LsrcService();

            BrightLocalGetAllResults lsrcList = lsrcService.GetAll();
            return lsrcList;
        }

        public static BrightLocalLsrcReport GetReport()
        {
            var campaignId = 1;
            var lsrcService = new LsrcService();

            BrightLocalLsrcReport myLsrc = lsrcService.Get(campaignId);
            return myLsrc;
        }

        public static BlSuccess Run()
        {
            var campaignId = 1;
            var lsrcService = new LsrcService();

            BlSuccess myLsrc = lsrcService.Run(campaignId);
            return myLsrc;
        }

        public static BrightLocalLsrcHistory GetHistory()
        {
            var campaignId = 1;
            var lsrcService = new LsrcService();

            BrightLocalLsrcHistory lsrcHistory = lsrcService.GetHistory(campaignId);
            return lsrcHistory;
        }

        public static BrightLocalLsrcReportResults GetReportResults()
        {
            var myLsrc = new GetResultsLsrcOptions();
            myLsrc.campaignId = 1;
            
            var lsrcService = new LsrcService();

            var lsrcResults = lsrcService.GetResults(myLsrc);
            return lsrcResults;
        }
    }
}
