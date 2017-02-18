namespace BrightLocal.Examples_version2.Account_Methods
{
    public class citationTrackerExamples
    {
        public static BlSuccess Create()
        {
            CitationTracker ct = new CitationTracker();
            ct.reportName = "Sample Citation Tracker Report";
            ct.businessName = "Le Bernardin";
            ct.website = "le-bernardin.com";
            ct.businessType = "Restaurant";            
            ct.stateCode = "NY";
            ct.postcode = "10019";
            ct.phone = "+1 212-554-1515";
            ct.country = "USA";

            var citationTrackerService = new CitationTrackerService();

            BlSuccess newCt = citationTrackerService.Create(ct);

            return newCt;            
        }

        public static BlSuccess Update()
        {
            UpdateCitationTracker ct = new UpdateCitationTracker();
            ct.reportId = 682;
            ct.reportName = "Sample Citation Tracker Report";
            ct.businessName = "Le Bernardin";
            ct.website = "le-bernardin.com";
            ct.businessType = "Restaurant";
            ct.stateCode = "NY";
            ct.postcode = "10019";
            ct.phone = "+1 212-554-1515";
            ct.country = "USA";

            var citationTrackerService = new CitationTrackerService();

            BlSuccess updateCt = citationTrackerService.Update(ct);

            return updateCt;
        }

        public static BlCitationTrackerReport Get()
        {
            int reportId = 682;

            var citationTrackerService = new CitationTrackerService();

            BlCitationTrackerReport ct = citationTrackerService.Get(reportId);

            return ct;
        }

        public static BlSuccess Run()
        {
            int reportId = 682;

            var citationTrackerService = new CitationTrackerService();

            BlSuccess ct = citationTrackerService.Run(reportId);

            return ct;
        }

        public static BlSuccess Delete()
        {
            int reportId = 682;

            var citationTrackerService = new CitationTrackerService();

            BlSuccess ct = citationTrackerService.Delete(reportId);

            return ct;
        }

        public static BlCtGetAllResults GetAll()
        {
            
            var citationTrackerService = new CitationTrackerService();

            BlCtGetAllResults ctResults = citationTrackerService.GetAll();

            return ctResults;
        }

        public static BlCitationTrackerResults GetReportResults()
        {
            var reportId = 1;
            var citationTrackerService = new CitationTrackerService();

            BlCitationTrackerResults ctResults = citationTrackerService.GetReportResults(reportId);

            return ctResults;
        }
    }
}
