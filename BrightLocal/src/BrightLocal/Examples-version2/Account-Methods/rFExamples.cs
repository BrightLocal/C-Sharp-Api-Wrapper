using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class rFExamples
    {
        public static BrightLocalSuccess Create()
        {
            var myReviewReport = new ReviewFlowOptions();            
            myReviewReport.reportName = "Sample Citation Tracker Report";
            myReviewReport.businessName = "Le Bernardin";
            myReviewReport.contactTelephone = "+1 212-554-1515";
            myReviewReport.address1 = "155 Weest 51st Street";
            myReviewReport.address2 = "";
            myReviewReport.city = "NYC";
            myReviewReport.postcode = "10019";
            myReviewReport.country = "USA";

            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            myReviewReport.directories.Add(
                "citysearch",
                new Directories
                {
                    url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
                    include = true
                });
            myReviewReport.directories.Add(
                "dexknows",
                new Directories
                {
                    url = "",
                    include = true
                });

            var rfService = new ReviewFlowService();

            BrightLocalSuccess newReviewReport = rfService.Create(myReviewReport);
            return newReviewReport;
        }

        public static BrightLocalSuccess Update()
        {
            var myReviewReport = new UpdateReviewFlowOptions();
            myReviewReport.reportId = 1;
            myReviewReport.reportName = "Sample Citation Tracker Report";
            myReviewReport.businessName = "Le Bernardin";
            myReviewReport.contactTelephone = "+1 212-554-1515";
            myReviewReport.address1 = "155 Weest 51st Street";
            myReviewReport.address2 = "";
            myReviewReport.city = "NYC";
            myReviewReport.postcode = "10019";
            myReviewReport.country = "USA";

            // Example for supplying Local Directory URLs (see local-directory-urls parameter)
            myReviewReport.directories.Add(
                "citysearch",
                new Directories
                {
                    url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
                    include = true
                });
            myReviewReport.directories.Add(
                "dexknows",
                new Directories
                {
                    url = "",
                    include = true
                });

            var rfService = new ReviewFlowService();

            BrightLocalSuccess updateReviewReport = rfService.Update(myReviewReport);
            return updateReviewReport;
        }

        public static BrightLocalRfReport GetReport()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalRfReport reviewReport = rfService.Get(reportId);
            return reviewReport;
        }

        public static BrightLocalSuccess DeleteReport()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalSuccess deleteReport = rfService.Delete(reportId);
            return deleteReport;
        }

        public static BrightLocalRfGetAll GetAllReports()
        {           
            var rfService = new ReviewFlowService();

            BrightLocalRfGetAll results = rfService.GetAll();
            return results;
        }

        public static BrightLocalRfGetAll SearchReport()
        {
            string query = "New York";
            var rfService = new ReviewFlowService();

            BrightLocalRfGetAll results = rfService.Search(query);
            return results;
        }

        public static BrightLocalRfReviews GetReviews()
        {
            var myReviewReport = new RfGetReviewsOptions();
            myReviewReport.reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalRfReviews reviews = rfService.GetReviews(myReviewReport);
            return reviews;
        }

        public static BrightLocalSuccess GetReviewCount()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalSuccess reviewCount = rfService.GetReviewCount(reportId);
            return reviewCount;
        }

        public static BrightLocalSuccess GetGrowth()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalSuccess reviewGrowth = rfService.GetGrowth(reportId);
            return reviewGrowth;
        }

        public static BrightLocalRfDirectories GetDirectories()
        {
            int reportId = 1;
            var rfService = new ReviewFlowService();

            BrightLocalRfDirectories reviewDirectories = rfService.GetDirectories(reportId);
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
