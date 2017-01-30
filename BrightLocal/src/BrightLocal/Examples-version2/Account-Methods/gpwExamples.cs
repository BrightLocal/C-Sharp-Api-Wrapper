using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class gpwExamples
    {
        public static BrightLocalSuccess Create()
        {
            var myGpwReport = new GpwOptions();
            myGpwReport.reportName = "Sample Citation Tracker Report";
            myGpwReport.businessNames = "Le Bernardin";
            myGpwReport.schedule = "Adhoc";
            myGpwReport.dayOfMonth = "2";
            myGpwReport.reportType = "with";           
            myGpwReport.address1 = "155 Weest 51st Street";
            myGpwReport.address2 = "";
            myGpwReport.city = "NYC";
            myGpwReport.stateCode = "NY";
            myGpwReport.postcode = "10019";
            myGpwReport.phoneNumber = "+1 212-554-1515";
            myGpwReport.country = "USA";
            myGpwReport.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

            var gpwService = new GpwService();

            BrightLocalSuccess gpwReport = gpwService.Create(myGpwReport);
            return gpwReport;
        }

        public static BrightLocalSuccess Update()
        {
            var myGpwReport = new UpdateGpwOptions();
            myGpwReport.reportId = 1;
            myGpwReport.reportName = "Sample Citation Tracker Report";
            myGpwReport.businessNames = "Le Bernardin";
            myGpwReport.schedule = "Adhoc";
            myGpwReport.dayOfMonth = "2";
            myGpwReport.reportType = "with";
            myGpwReport.address1 = "155 Weest 51st Street";
            myGpwReport.address2 = "";
            myGpwReport.city = "NYC";
            myGpwReport.stateCode = "NY";
            myGpwReport.postcode = "10019";
            myGpwReport.phoneNumber = "+1 212-554-1515";
            myGpwReport.country = "USA";
            myGpwReport.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

            var gpwService = new GpwService();

            BrightLocalSuccess gpwReport = gpwService.Update(myGpwReport);
            return gpwReport;
        }

        public static BrightLocalGpwReport Get()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BrightLocalGpwReport gpwReport = gpwService.Get(reportId);
            return gpwReport;
        }

        public static BrightLocalSuccess Delete()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BrightLocalSuccess gpwReport = gpwService.Delete(reportId);
            return gpwReport;
        }

        public static BrightLocalGpwGetAllResults GetAll()
        {
            var gpwService = new GpwService();

            BrightLocalGpwGetAllResults gpwGetAllResults = gpwService.GetAll();
            return gpwGetAllResults;
        }

        public static BrightLocalSuccess Run()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BrightLocalSuccess gpwReport = gpwService.Run(reportId);
            return gpwReport;
        }

        public static BrightLocalGpwReportResults GetResults()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BrightLocalGpwReportResults gpwReport = gpwService.GetReportResults(reportId);
            return gpwReport;
        }
    }
}
