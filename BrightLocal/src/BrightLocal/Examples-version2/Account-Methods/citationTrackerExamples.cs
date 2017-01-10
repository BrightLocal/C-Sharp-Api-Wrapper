using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class citationTrackerExamples
    {
        public static BrightLocalSuccess Create()
        {
            CitationTrackerOptions myCt = new CitationTrackerOptions();
            myCt.reportName = "Sample Citation Tracker Report";
            myCt.businessName = "Le Bernardin";
            myCt.website = "le-bernardin.com";
            myCt.businessType = "Restaurant";
            myCt.stateCode = "NY";
            myCt.postcode = "10019";
            myCt.phone = "+1 212-554-1515";
            myCt.country = "USA";

            var citationTrackerService = new CitationTrackerService();

            BrightLocalSuccess newCt = citationTrackerService.Create(myCt);

            return newCt;            
        }

        public static BrightLocalSuccess Update()
        {
            UpdateCitationTrackerOptions myCt = new UpdateCitationTrackerOptions();
            myCt.reportId = 682;
            myCt.reportName = "Sample Citation Tracker Report";
            myCt.businessName = "Le Bernardin";
            myCt.website = "le-bernardin.com";
            myCt.businessType = "Restaurant";
            myCt.stateCode = "NY";
            myCt.postcode = "10019";
            myCt.phone = "+1 212-554-1515";
            myCt.country = "USA";

            var citationTrackerService = new CitationTrackerService();

            BrightLocalSuccess updateCt = citationTrackerService.Update(myCt);

            return updateCt;
        }

        public static BrightLocalCitationTrackerReport Get()
        {
            int reportId = 682;

            var citationTrackerService = new CitationTrackerService();

            BrightLocalCitationTrackerReport myCt = citationTrackerService.Get(reportId);

            return myCt;
        }

        public static BrightLocalSuccess Run()
        {
            int reportId = 682;

            var citationTrackerService = new CitationTrackerService();

            BrightLocalSuccess myCt = citationTrackerService.Run(reportId);

            return myCt;
        }

        public static BrightLocalSuccess Delete()
        {
            int reportId = 682;

            var citationTrackerService = new CitationTrackerService();

            BrightLocalSuccess myCt = citationTrackerService.Delete(reportId);

            return myCt;
        }

        public static BrightLocalCtGetAllResults GetAll()
        {
            
            var citationTrackerService = new CitationTrackerService();

            BrightLocalCtGetAllResults ctResults = citationTrackerService.GetAll();

            return ctResults;
        }

        public static BrightLocalCitationTrackerResults GetReportResults()
        {
            var reportId = 1;
            var citationTrackerService = new CitationTrackerService();

            BrightLocalCitationTrackerResults ctResults = citationTrackerService.GetReportResults(reportId);

            return ctResults;
        }
    }
}
