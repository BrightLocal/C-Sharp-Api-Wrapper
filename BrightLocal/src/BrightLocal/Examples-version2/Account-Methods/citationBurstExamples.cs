using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class citationBurstExamples
    {
        public static BrightLocalSuccess Create()
        {
            string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Coze’s set to open Le Bernardin in New York in 1986.";
            string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the World’s 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of “Best Food” for the last nine consecutive years, and in 2015 was rated by the guide as New York City’s top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including “Outstanding Restaurant of the Year,” “Top Chef in New York City,” “Outstanding Service,” “Outstanding Chef in the United States,” “Outstanding Pastry Chef,” “Outstanding Wine Service,” and “Best Restaurant Design” in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

            CitationBurstOptions myCb = new CitationBurstOptions();            
            myCb.businessName = "Le Bernardin";
            myCb.campaignName = "Sample Citation Burst Campaign";
            myCb.websiteAddress = "le-bernardin.com";
            myCb.campaignCountry = "USA";
            myCb.campaignState = "NY";
            myCb.campaignCity = "New York";
            myCb.businessCategoryId = 605;
            myCb.businessCategories = new List<string>() { "restaurant", "cafe" };
            myCb.address1 = "155 Weest 51st Street";
            myCb.address2 = "";
            myCb.postcode = "10019";
            myCb.contactName = "Hanane Moshe";
            myCb.contactFirstName = "Hanane";
            myCb.contactTelephone = "+1 212-554-1515";
            myCb.briefDescription = brief_description;
            myCb.fullDescription = full_description;
            myCb.employeesNumber = 35;
            myCb.startYear = 1976;
            myCb.workingHoursApplyToAll = 0;
            myCb.workingHoursMonStart = 0800;
            myCb.workingHoursMonEnd = 2200;
            myCb.workingHoursTueStart = 0800;
            myCb.workingHoursTueEnd = 2200;
            myCb.workingHoursWedStart = 0800;
            myCb.workingHoursWedEnd = 2200;
            myCb.workingHoursThuStart = 0800;
            myCb.workingHoursThuEnd = 2200;
            myCb.workingHoursFriStart = 0800;
            myCb.workingHoursFriEnd = 2200;
            myCb.workingHoursSatStart = 1000;
            myCb.workingHoursSatEnd = 2400;
            myCb.workingHoursSunStart = 1000;
            myCb.workingHoursSunEnd = 2400;
            myCb.paymentMethods = "Cash|Visa";

            var citationBurstService = new CitationBurstService();

            BrightLocalSuccess newCb = citationBurstService.Create(myCb);

            return newCb;
        }

        public static BrightLocalSuccess Update()
        {
            string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Coze’s set to open Le Bernardin in New York in 1986.";
            string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the World’s 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of “Best Food” for the last nine consecutive years, and in 2015 was rated by the guide as New York City’s top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including “Outstanding Restaurant of the Year,” “Top Chef in New York City,” “Outstanding Service,” “Outstanding Chef in the United States,” “Outstanding Pastry Chef,” “Outstanding Wine Service,” and “Best Restaurant Design” in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

            UpdateCitationBurstOptions myCb = new UpdateCitationBurstOptions();
            myCb.campaignId = 1;
            myCb.businessName = "Le Bernardin";
            myCb.campaignName = "Sample Citation Burst Campaign";
            myCb.websiteAddress = "le-bernardin.com";
            myCb.campaignCountry = "USA";
            myCb.campaignState = "NY";
            myCb.campaignCity = "New York";
            myCb.businessCategoryId = 605;
            myCb.businessCategories = new List<string>() { "restaurant", "cafe" };
            myCb.address1 = "155 Weest 51st Street";
            myCb.address2 = "";
            myCb.postcode = "10019";
            myCb.contactName = "Hanane Moshe";
            myCb.contactFirstName = "Hanane";
            myCb.contactTelephone = "+1 212-554-1515";
            myCb.briefDescription = brief_description;
            myCb.fullDescription = full_description;
            myCb.employeesNumber = 35;
            myCb.startYear = 1976;
            myCb.workingHoursApplyToAll = 0;
            myCb.workingHoursMonStart = 0800;
            myCb.workingHoursMonEnd = 2200;
            myCb.workingHoursTueStart = 0800;
            myCb.workingHoursTueEnd = 2200;
            myCb.workingHoursWedStart = 0800;
            myCb.workingHoursWedEnd = 2200;
            myCb.workingHoursThuStart = 0800;
            myCb.workingHoursThuEnd = 2200;
            myCb.workingHoursFriStart = 0800;
            myCb.workingHoursFriEnd = 2200;
            myCb.workingHoursSatStart = 1000;
            myCb.workingHoursSatEnd = 2400;
            myCb.workingHoursSunStart = 1000;
            myCb.workingHoursSunEnd = 2400;
            myCb.paymentMethods = "Cash|Visa";

            var citationBurstService = new CitationBurstService();

            BrightLocalSuccess newCb = citationBurstService.Update(myCb);

            return newCb;
        }

        public static BrightLocalSuccess UploadImage()
        {
            CbUploadImage image = new CbUploadImage();
            image.campaignId = 1;
            image.file = "/path/to/image.jpg";
            image.imageType = "logo";

            var citationBurstService = new CitationBurstService();

            BrightLocalSuccess cbImage = citationBurstService.UploadImage(image);

            return cbImage;
        }

        public static BrightLocalCitations GetCitations()
        {
            int campaingId = 1;

            var citationBurstService = new CitationBurstService();

            BrightLocalCitations citations = citationBurstService.GetCitations(campaingId);

            return citations;
        }

        public static BrightLocalSuccess ConfirmAndPay()
        {
            BrightLocalCbPayOptions confirmPay = new BrightLocalCbPayOptions();
            confirmPay.campaign_id = 1;
            confirmPay.package_id = "cb15";

            var citationBurstService = new CitationBurstService();

            BrightLocalSuccess confirm = citationBurstService.ConfirmAndPay(confirmPay);

            return confirm;
        }

        public static BrightLocalCbAllCampaigns GetAll()
        {
            var citationBurstService = new CitationBurstService();

            BrightLocalCbAllCampaigns results = citationBurstService.GetCampaigns();

            return results;
        }

        public static BrightLocalCbCampaign GetCampaign()
        {
            int campaignId = 1;
            var citationBurstService = new CitationBurstService();

            BrightLocalCbCampaign results = citationBurstService.GetCampaign(campaignId);

            return results;
        }

        public static BrightLocalSuccess GetCredits()
        {
            var citationBurstService = new CitationBurstService();

            BrightLocalSuccess credits = citationBurstService.GetCredits();

            return credits;
        }
    }
}
