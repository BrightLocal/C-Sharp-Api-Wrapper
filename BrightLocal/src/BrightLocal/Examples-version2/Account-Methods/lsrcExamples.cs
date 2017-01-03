using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class lsrcExamples
    {
        public static BrightLocalLsrc Create()
        {
            var myLsrc = new LsrcOptions();
            myLsrc.name = "Le Bernardin";
            myLsrc.websiteAddresses = new List<string>() {"le-bernardin.com", "www.le-bernadin.com"};
            myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
            myLsrc.schedule = "Adhoc";
            myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";
          
            var lsrcService = new LsrcService();

            BrightLocalLsrc newLsrc = lsrcService.Create(myLsrc);
            return newLsrc;
        }

    }
}
