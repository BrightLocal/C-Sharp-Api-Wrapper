using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class citationBurstExamples
    {
        public static BlSuccess Create()
        {
            string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Coze’s set to open Le Bernardin in New York in 1986.";
            string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the World’s 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of “Best Food” for the last nine consecutive years, and in 2015 was rated by the guide as New York City’s top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including “Outstanding Restaurant of the Year,” “Top Chef in New York City,” “Outstanding Service,” “Outstanding Chef in the United States,” “Outstanding Pastry Chef,” “Outstanding Wine Service,” and “Best Restaurant Design” in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

            CitationBurstOptions cb = new CitationBurstOptions();            
            cb.businessName = "Le Bernardin";
            cb.campaignName = "Sample Citation Burst Campaign";
            cb.websiteAddress = "le-bernardin.com";
            cb.campaignCountry = "USA";
            cb.campaignState = "NY";
            cb.campaignCity = "New York";
            cb.businessCategoryId = 605;
            cb.businessCategories = new List<string>() { "restaurant", "cafe" };
            cb.address1 = "155 Weest 51st Street";
            cb.address2 = "";
            cb.postcode = "10019";
            cb.contactName = "Hanane Moshe";
            cb.contactFirstName = "Hanane";
            cb.contactTelephone = "+1 212-554-1515";
            cb.briefDescription = brief_description;
            cb.fullDescription = full_description;
            cb.employeesNumber = 35;
            cb.startYear = 1976;
            cb.workingHoursApplyToAll = 0;
            cb.workingHoursMonStart = 0800;
            cb.workingHoursMonEnd = 2200;
            cb.workingHoursTueStart = 0800;
            cb.workingHoursTueEnd = 2200;
            cb.workingHoursWedStart = 0800;
            cb.workingHoursWedEnd = 2200;
            cb.workingHoursThuStart = 0800;
            cb.workingHoursThuEnd = 2200;
            cb.workingHoursFriStart = 0800;
            cb.workingHoursFriEnd = 2200;
            cb.workingHoursSatStart = 1000;
            cb.workingHoursSatEnd = 2400;
            cb.workingHoursSunStart = 1000;
            cb.workingHoursSunEnd = 2400;
            cb.paymentMethods = "Cash|Visa";

            var citationBurstService = new CitationBurstService();

            BlSuccess newCb = citationBurstService.Create(cb);

            return newCb;
        }

        public static BlSuccess Update()
        {
            string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Coze’s set to open Le Bernardin in New York in 1986.";
            string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the World’s 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of “Best Food” for the last nine consecutive years, and in 2015 was rated by the guide as New York City’s top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including “Outstanding Restaurant of the Year,” “Top Chef in New York City,” “Outstanding Service,” “Outstanding Chef in the United States,” “Outstanding Pastry Chef,” “Outstanding Wine Service,” and “Best Restaurant Design” in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

            UpdateCitationBurstOptions cb = new UpdateCitationBurstOptions();
            cb.campaignId = 1;
            cb.businessName = "Le Bernardin";
            cb.campaignName = "Sample Citation Burst Campaign";
            cb.websiteAddress = "le-bernardin.com";
            cb.campaignCountry = "USA";
            cb.campaignState = "NY";
            cb.campaignCity = "New York";
            cb.businessCategoryId = 605;
            cb.businessCategories = new List<string>() { "restaurant", "cafe" };
            cb.address1 = "155 Weest 51st Street";
            cb.address2 = "";
            cb.postcode = "10019";
            cb.contactName = "Hanane Moshe";
            cb.contactFirstName = "Hanane";
            cb.contactTelephone = "+1 212-554-1515";
            cb.briefDescription = brief_description;
            cb.fullDescription = full_description;
            cb.employeesNumber = 35;
            cb.startYear = 1976;
            cb.workingHoursApplyToAll = 0;
            cb.workingHoursMonStart = 0800;
            cb.workingHoursMonEnd = 2200;
            cb.workingHoursTueStart = 0800;
            cb.workingHoursTueEnd = 2200;
            cb.workingHoursWedStart = 0800;
            cb.workingHoursWedEnd = 2200;
            cb.workingHoursThuStart = 0800;
            cb.workingHoursThuEnd = 2200;
            cb.workingHoursFriStart = 0800;
            cb.workingHoursFriEnd = 2200;
            cb.workingHoursSatStart = 1000;
            cb.workingHoursSatEnd = 2400;
            cb.workingHoursSunStart = 1000;
            cb.workingHoursSunEnd = 2400;
            cb.paymentMethods = "Cash|Visa";

            var citationBurstService = new CitationBurstService();

            BlSuccess newCb = citationBurstService.Update(cb);

            return newCb;
        }

        public static BlSuccess UploadImage()
        {
            CbUploadImage image = new CbUploadImage();
            image.campaignId = 1;
            image.file = "/path/to/image.jpg";
            image.imageType = "logo";

            var citationBurstService = new CitationBurstService();

            BlSuccess cbImage = citationBurstService.UploadImage(image);

            return cbImage;
        }

        public static BlCitations GetCitations()
        {
            int campaingId = 1;

            var citationBurstService = new CitationBurstService();

            BlCitations citations = citationBurstService.GetCitations(campaingId);

            return citations;
        }

        public static BlSuccess ConfirmAndPay()
        {
            BrightLocalCbPayOptions confirmPay = new BrightLocalCbPayOptions();
            confirmPay.campaign_id = 1;
            confirmPay.package_id = "cb15";

            var citationBurstService = new CitationBurstService();

            BlSuccess confirm = citationBurstService.ConfirmAndPay(confirmPay);

            return confirm;
        }

        public static BlCbAllCampaigns GetAll()
        {
            var citationBurstService = new CitationBurstService();

            BlCbAllCampaigns results = citationBurstService.GetCampaigns();

            return results;
        }

        public static BlCbCampaign GetCampaign()
        {
            int campaignId = 1;
            var citationBurstService = new CitationBurstService();

            BlCbCampaign results = citationBurstService.GetCampaign(campaignId);

            return results;
        }

        public static BlSuccess GetCredits()
        {
            var citationBurstService = new CitationBurstService();

            BlSuccess credits = citationBurstService.GetCredits();

            return credits;
        }
    }
}
