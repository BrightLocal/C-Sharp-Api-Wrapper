using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class rFExamples
    {
        public static BlSuccess Create()
        {
            var reviewReport = new ReviewFlow();            
            reviewReport.reportName = "Sample Citation Tracker Report";
            reviewReport.businessName = "Le Bernardin";
            reviewReport.contactTelephone = "+1 212-554-1515";
            reviewReport.address1 = "155 Weest 51st Street";
            reviewReport.address2 = "";
            reviewReport.city = "NYC";
            reviewReport.postcode = "10019";
            reviewReport.country = "USA";

            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            reviewReport.directories.Add(
                "citysearch",
                new Directories
                {
                    url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
                    include = true
                });
            reviewReport.directories.Add(
                "dexknows",
                new Directories
                {
                    url = "",
                    include = true
                });

            var rfService = new ReviewFlowService();

            BlSuccess newReviewReport = rfService.Create(reviewReport);
            return newReviewReport;
        }

        public static BlSuccess Update()
        {
            var reviewReport = new UpdateReviewFlow();
            reviewReport.reportId = 1;
            reviewReport.reportName = "Sample Citation Tracker Report";
            reviewReport.businessName = "Le Bernardin";
            reviewReport.contactTelephone = "+1 212-554-1515";
            reviewReport.address1 = "155 Weest 51st Street";
            reviewReport.address2 = "";
            reviewReport.city = "NYC";
            reviewReport.postcode = "10019";
            reviewReport.country = "USA";

            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            reviewReport.directories.Add(
                "citysearch",
                new Directories
                {
                    url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
                    include = true
                });
            reviewReport.directories.Add(
                "dexknows",
                new Directories
                {
                    url = "",
                    include = true
                });

            var rfService = new ReviewFlowService();

            BlSuccess updateReviewReport = rfService.Update(reviewReport);
            return updateReviewReport;
        }

        public static BlRfReport GetReport()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BlRfReport reviewReport = rfService.Get(reportId);
            return reviewReport;
        }

        public static BlSuccess DeleteReport()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BlSuccess deleteReport = rfService.Delete(reportId);
            return deleteReport;
        }

        public static BlRfGetAll GetAllReports()
        {           
            var rfService = new ReviewFlowService();

            BlRfGetAll results = rfService.GetAll();
            return results;
        }

        public static BlRfGetAll SearchReport()
        {
            string query = "New York";
            var rfService = new ReviewFlowService();

            BlRfGetAll results = rfService.Search(query);
            return results;
        }

        public static BlRfReviews GetReviews()
        {
            var reviewReport = new RfGetReviews();
            reviewReport.reportId = 1;
            var rfService = new ReviewFlowService();

            BlRfReviews reviews = rfService.GetReviews(reviewReport);
            return reviews;
        }

        public static BlSuccess GetReviewCount()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BlSuccess reviewCount = rfService.GetReviewCount(reportId);
            return reviewCount;
        }

        public static BlSuccess GetGrowth()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BlSuccess reviewGrowth = rfService.GetGrowth(reportId);
            return reviewGrowth;
        }

        public static BlRfDirectories GetDirectories()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BlRfDirectories reviewDirectories = rfService.GetDirectories(reportId);
            return reviewDirectories;
        }

        public static BrightLocalRfDirectoryStats GetDirectoryStats()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalRfDirectoryStats reviewDirectoryStats = rfService.GetDirectoryStats(reportId);
            return reviewDirectoryStats;
        }

        public static BrightLocalRfStarCounts GetStarCount()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalRfStarCounts reviewStarCount = rfService.GetStarCount(reportId);
            return reviewStarCount;
        }
    }
}
