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
            var gpwReport = new Gpw();
            gpwReport.reportName = "Sample Citation Tracker Report";
            gpwReport.businessNames = "Le Bernardin";
            gpwReport.schedule = "Adhoc";
            gpwReport.dayOfMonth = "2";
            gpwReport.reportType = "with";           
            gpwReport.address1 = "155 Weest 51st Street";
            gpwReport.address2 = "";
            gpwReport.city = "NYC";
            gpwReport.stateCode = "NY";
            gpwReport.postcode = "10019";
            gpwReport.phoneNumber = "+1 212-554-1515";
            gpwReport.country = "USA";
            gpwReport.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

            var gpwService = new GpwService();

            BlSuccess gpwReportResults = gpwService.Create(gpwReport);
            return gpwReportResults;
        }

        public static BlSuccess Update()
        {
            var gpwReport = new UpdateGpw();
            gpwReport.reportId = 1;
            gpwReport.reportName = "Sample Citation Tracker Report";
            gpwReport.businessNames = "Le Bernardin";
            gpwReport.schedule = "Adhoc";
            gpwReport.dayOfMonth = "2";
            gpwReport.reportType = "with";
            gpwReport.address1 = "155 Weest 51st Street";
            gpwReport.address2 = "";
            gpwReport.city = "NYC";
            gpwReport.stateCode = "NY";
            gpwReport.postcode = "10019";
            gpwReport.phoneNumber = "+1 212-554-1515";
            gpwReport.country = "USA";
            gpwReport.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

            var gpwService = new GpwService();

            BlSuccess gpwReportResults = gpwService.Update(gpwReport);
            return gpwReportResults;
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
