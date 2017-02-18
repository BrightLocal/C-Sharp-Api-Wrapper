using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class gpwExamples
    {
        public static BlSuccess Create()
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

            BlSuccess gpwReport = gpwService.Create(myGpwReport);
            return gpwReport;
        }

        public static BlSuccess Update()
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

            BlSuccess gpwReport = gpwService.Update(myGpwReport);
            return gpwReport;
        }

        public static BlGpwReport Get()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BlGpwReport gpwReport = gpwService.Get(reportId);
            return gpwReport;
        }

        public static BlSuccess Delete()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BlSuccess gpwReport = gpwService.Delete(reportId);
            return gpwReport;
        }

        public static BlGpwGetAllResults GetAll()
        {
            var gpwService = new GpwService();

            BlGpwGetAllResults gpwGetAllResults = gpwService.GetAll();
            return gpwGetAllResults;
        }

        public static BlSuccess Run()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BlSuccess gpwReport = gpwService.Run(reportId);
            return gpwReport;
        }

        public static BlGpwReportResults GetResults()
        {
            var reportId = 1;
            var gpwService = new GpwService();

            BlGpwReportResults gpwReport = gpwService.GetReportResults(reportId);
            return gpwReport;
        }
    }
}
