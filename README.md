**BrightLocal API Wrapper Version 2.0**

For documentation for version 1.0 [click nere](Documentation/README.md).

**BrightLocal API Services**

* [Clients](#clients)  
* [Locations](#locations)  
* [Local Search Rank Checker](#local-search-rank-checker)  
* [Local SEO Check-up](#local-seo-check-up)  
* [Citation Tracker](#citation-tracker)  
* [Citation Burst](#citation-burst)  
* [ReviewFlow Reports](#reviewflow-reports)  
* [Google+ Local Wizard Reports](#google-plus-local-wizard-reports)  

Quick Start
-----------

We recommend that you install BrightLocal via NuGet ` nuget Install-Package BrightLocal` (https://www.nuget.org/packages/BrightLocal/1.0.0/).

```csharp
   nuget Install-Package BrightLocal
```

Next you will need to provide BrightLocal with your API key & API secret. There are currently three ways to do this:

1) Add an AppSetting with your API key to your config (this is the easiest way and will work throughout the app on every request) 

```xml
	<appSettings>
	...
		<add key="BrightLocalApiKey" value="[your api key here]" />
		<add key="BrightLocalApiSecret" value="[your api secret here]" />
	...
	</appSettings>
```

2) In your application initialization, call this method (this is a programmatic way, but you only have to do it once during startup)

```csharp
	BrightLocalConfiguration.SetApiCredentials("[your API key here]", "[your api secret here]");
```

3) In any of the service constructors, you can optionally pass the API key & API secret (will be assigned that apikey for the life of the service instance).

```csharp
	var clientService = new ClientService("[your api key here]", "[your api secret here]");
```

Clients
-----

### Add Client

```csharp
	var myClient = new ClientOptions();
    myClient.name = "Le Bernardin";
    myClient.companyUrl = "le-bernardin.com";
    myClient.businessCategoryId = 791;

    var clientService = new ClientService();

    BrightLocalSuccess newClient = clientService.Create(myClient);
```

The returned BrightLocalSuccess entity above will have a client-id. You will want to persist this for later. When you create a location you will be able to optionally assign it to a client ID.

### Update Client

```csharp
	var myClient = new UpdateClientOptions();
    myClient.clientId = 36447;
    myClient.name = "Le Bernardin";
    myClient.companyUrl = "le-bernardin.com";
    myClient.businessCategoryId = 791;

    var clientService = new ClientService();

    BrightLocalSuccess updateClient = clientService.Update(myClient);
```

### Delete Client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BrightLocalSuccess deleteClient = clientService.Delete(clientId);
```

### Get Client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BrightLocalClient client = clientService.Get(clientId);
```

### Search Clients

```csharp
	var searchQuery = "le-bernardin";
    var clientService = new ClientService();

    BrightLocalClientSearch results = clientService.Search(searchQuery);
```


Locations
-----

### Add Location

```csharp
	var myLocation = new LocationOptions();
    myLocation.name = "Le Bernardin";
    myLocation.url = "le-bernardin.com";
    myLocation.businessCategoryId = 791;
    myLocation.country = "USA";
    myLocation.address1 = "155 Weest 51st Street";
    myLocation.address2 = "";
    myLocation.region = "NY"; // state or region
    myLocation.city = "New York";
    myLocation.postcode = "10019";
    myLocation.telephone = "+1 212-554-1515";

    var locationService = new LocationService();

    var BrightLocalSuccess = locationService.Create(myLocation);
```

The returned BrightLocalSuccess entity above will have a location-id. You will want to persist this for later. When you create a report you will be able to optionally assign it to a location id.

### Update Location

```csharp
	var myLocation = new UpdateLocationOptions();
	myLocation.locationId = 1;
	myLocation.name = "Le Bernardin";
	myLocation.url = "le-bernardin.com";
	myLocation.businessCategoryId = 791;
	myLocation.country = "USA";
	myLocation.address1 = "155 Weest 51st Street";
	myLocation.address2 = "";
	myLocation.region = "NY"; // state or region
	myLocation.city = "New York";
	myLocation.postcode = "10019";
	myLocation.telephone = "+1 212-554-1515";

	var locationService = new LocationService();

	BrightLocalSuccess updateLocation = locationService.Update(myLocation);
```

### Delete Location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BrightLocalSuccess deleteLocation = locationService.Delete(locationId);          
```

### Get Location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BrightLocalLocation getLocation = locationService.Get(locationId);
```

### Search Locations

```csharp
	var searchQuery = "le-bernardin";
    var locationService = new LocationService();

    BrightLocalLocationSearch results = locationService.Search(searchQuery); 
```

Local Search Rank Checker
-----

### Add Report

```csharp
	var myLsrc = new LsrcOptions();
    myLsrc.name = "Le Bernardin";
    myLsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() {"le-bernardin.com", "www.le-bernadin.com"});
    myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
    myLsrc.schedule = "Adhoc";
    myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";
          
    var lsrcService = new LsrcService();

    BrightLocalSuccess newLsrc = lsrcService.Create(myLsrc);
```

The returned BrightLocalSuccess entity above will have a campaign-id. You will want to persist this for later in order to run and fetch the report.

### Update Report

```csharp
	var myLsrc = new UpdateLsrcOptions();
    myLsrc.campaignId = 1;
    myLsrc.name = "Le Bernardin";
    myLsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() { "le-bernardin.com", "www.le-bernadin.com" });
    myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
    myLsrc.schedule = "Adhoc";
    myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";

    var lsrcService = new LsrcService();

    BrightLocalSuccess updatedLsrc = lsrcService.Update(myLsrc);
```

### Delete Report

```csharp
	var campaignId = 1;           
    var lsrcService = new LsrcService();

    BrightLoBrightLocalSuccesscalLsrc deletedLsrc = lsrcService.Delete(campaignId);
```

### Get Reports

```csharp
	var lsrcService = new LsrcService();

    BrightLocalGetAllResults lsrcList = lsrcService.GetAll();;
```

### Get Report

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BrightLocalLsrcReport myLsrc = lsrcService.Get(campaignId);
```

### Run Report

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BrightLocalLsrc myLsrc = lsrcService.Run(campaignId);
```

### Get Report History

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BrightLocalLsrcHistory lsrcHistory = lsrcService.GetHistory(campaignId);
```

### Get Report Results

```csharp
	var myLsrc = new GetResultsLsrcOptions();
	myLsrc.campaignId = 1;
            
	var lsrcService = new LsrcService();

	BrightLocalLsrcReportResults lsrcResults = lsrcService.GetResults(myLsrc);
```


Local SEO Check-up
-----

### Add Report

```csharp
	LscuOptions myLscu = new LscuOptions();
    myLscu.reportName = "Sample SEO Chek-Up Report";
    myLscu.businessNames = JsonConvert.SerializeObject(new List<string>() {"Le Bernardin", "Le Bernardin Cafe"});
    myLscu.websiteAddress = "le-bernardin.com";
    myLscu.address1 = "155 Weest 51st Street";
    myLscu.address2 = "";
    myLscu.city = "New York";
    myLscu.stateCode = "NY";
    myLscu.postcode = "10019";
    myLscu.telephone = "+1 212-554-1515";
    myLscu.country = "USA";
    myLscu.businessCategory = "Restaurant";
    myLscu.primaryBusinessLocation = "NY, New York";
    myLscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });       

    var lscuService = new LscuService();

    BrightLocalSuccess newLscu = lscuService.Create(myLscu);
```

The returned BrightLocalSuccess entity above will have a report-id. You will want to persist this for later when you get and run a report.

### Supplying Local Directory URLs (see local-directory-urls parameter)

```csharp
    myLscu.localDirectoryUrls = new LocalDirectoryUrls();
	myLscu.localDirectoryUrls.Add(
        "citysearch",
        new DirectoryUrls
        {
            url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
            include = "yes"
        });
    myLscu.localDirectoryUrls.Add(
        "dexknows",
        new DirectoryUrls
        {
            url = "",
            include = "yes"
        });
```

### Update Report

```csharp
	UpdateLscuOptions myLscu = new UpdateLscuOptions();
	myLscu.reportId = 1;
    myLscu.reportName = "Sample SEO Chek-Up Report";
    myLscu.businessNames =  JsonConvert.SerializeObject(new List<string>() { "Le Bernardin", "Le Bernardin Cafe" });
    myLscu.websiteAddress = "le-bernardin.com";
    myLscu.address1 = "155 Weest 51st Street";
    myLscu.address2 = "";
    myLscu.city = "New York";
    myLscu.stateCode = "NY";
    myLscu.postcode = "10019";
    myLscu.telephone = "+1 212-554-1515";
    myLscu.country = "USA";
    myLscu.businessCategory = "Restaurant";
    myLscu.primaryBusinessLocation = "NY, New York";
    myLscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

    var lscuService = new LscuService();

    BrightLocalSuccess updateLscu = lscuService.Update(myLscu);
```

### Get Report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BrightLocalLscuReport lscuReport = lscuService.Get(reportId);
```

### Run Report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BrightLocalSuccess success = lscuService.Run(reportId);
```
The returned success entity above is of type string. Success or Failure with errors.

### Delete Report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BrightLocalSuccess success = lscuService.Delete(reportId);
```
The returned success entity above is of type string. Success or Failure with errors.

### Search Reports

```csharp
	var searchQuery = "Bodega Wine Bar";
    var lscuService = new LscuService();

    BrightLocalLscuSearch lscuSearch = lscuService.Search(searchQuery);
```

Citation Tracker
-----

### Add Report

```csharp
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
```
The returned BrightLocalSuccess entity above will have a report-id. You will want to persist this for later in order to run and get the report.

### Update Report

```csharp
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
```

### Get Report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BrightLocalCitationTrackerReport myCt = citationTrackerService.Get(reportId);
```

### Run Report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BrightLocalSuccess myCt = citationTrackerService.Run(reportId);
```

### Delete Report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BrightLocalSuccess myCt = citationTrackerService.Delete(reportId);
```

### Get Reports

```csharp	
    var citationTrackerService = new CitationTrackerService();

    BrightLocalCtGetAllResults ctResults = citationTrackerService.GetAll();
```

### Get Report Results

```csharp	
    var reportId = 1;
    var citationTrackerService = new CitationTrackerService();

    BrightLocalCitationTrackerResults ctResults = citationTrackerService.GetReportResults(reportId);
```

Citation Burst
-----

### Create Campaign

```csharp
	string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Cozes set to open Le Bernardin in New York in 1986.";
    string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the Worlds 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of Best Food for the last nine consecutive years, and in 2015 was rated by the guide as New York Citys top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including Outstanding Restaurant of the Year, Top Chef in New York City, Outstanding Service, Outstanding Chef in the United States, Outstanding Pastry Chef, Outstanding Wine Service, and Best Restaurant Design in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

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
```
The returned BrightLocalSuccess entity above will have a campaign-id. You will want to persist this for later in order to get citations, confirm & pay, etc.

### Update Campaign

```csharp
	string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Cozes set to open Le Bernardin in New York in 1986.";
    string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the Worlds 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of Best Food for the last nine consecutive years, and in 2015 was rated by the guide as New York Citys top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including Outstanding Restaurant of the Year, Top Chef in New York City, Outstanding Service, Outstanding Chef in the United States, Outstanding Pastry Chef, Outstanding Wine Service, and Best Restaurant Design in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

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
```

### Upload Image

```csharp
	CbUploadImage image = new CbUploadImage();
    image.campaignId = 1;
    image.file = "/path/to/image.jpg";
    image.imageType = "logo";

    var citationBurstService = new CitationBurstService();

    BrightLocalSuccess cbImage = citationBurstService.UploadImage(image);
```

### Get Citations

```csharp
	int campaingId = 1;
    var citationBurstService = new CitationBurstService();

    BrightLocalCitations citations = citationBurstService.GetCitations(campaingId);
```

### Confirm & Pay for Citation Campaign

```csharp
	BrightLocalCbPayOptions confirmPay = new BrightLocalCbPayOptions();
    confirmPay.campaign_id = 1;
    confirmPay.package_id = "cb15";

    var citationBurstService = new CitationBurstService();

    BrightLocalSuccess confirm = citationBurstService.ConfirmAndPay(confirmPay);
```

### Getting All Campaigns

```csharp	
    var citationBurstService = new CitationBurstService();

    BrightLocalCbAllCampaigns results = citationBurstService.GetCampaigns();
```

### Get Campaign Details

```csharp	
    int campaignId = 1;
    var citationBurstService = new CitationBurstService();

    BrightLocalCbCampaign results = citationBurstService.GetCampaign(campaignId);
```

### Get Credits Balance

```csharp	
    var citationBurstService = new CitationBurstService();

    BrightLocalSuccess credits = citationBurstService.GetCredits();
```

ReviewFLow Reports
-----

### Add Report

```csharp
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
```

The returned BrightLocalSuccess entity above will have a report-id. You will want to persist this for later when you get a report.

### Update Report

```csharp
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
```

### Get Report

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfReport reviewReport = rfService.Get(reportId);
```

### Delete Report

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalSuccess deleteReport = rfService.Delete(reportId);
```

### Get All Reports

```csharp
	var rfService = new ReviewFlowService();

    BrightLocalRfGetAll results = rfService.GetAll();
```

### Search Reports

```csharp
	string query = "New York";
    var rfService = new ReviewFlowService();

    BrightLocalRfGetAll results = rfService.Search(query);
```

### Get Reviews

```csharp
	var myReviewReport = new RfGetReviewsOptions();
    myReviewReport.reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfReviews reviews = rfService.GetReviews(myReviewReport);
```

### Get Review Counts

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalSuccess reviewCount = rfService.GetReviewCount(reportId);
```

### Get Growth

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalSuccess reviewGrowth = rfService.GetGrowth(reportId);
```

### Get Directories

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfDirectories reviewDirectories = rfService.GetDirectories(reportId);
```

### Get Directory Stats

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfDirectoryStats reviewDirectoryStats = rfService.GetDirectoryStats(reportId);
```

### Get Star Counts

```csharp	
    int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfStarCounts reviewStarCount = rfService.GetStarCount(reportId);
```

Google Plus Local Wizard Reports
-----

### Add Report

```csharp
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
    myGpwReport.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };

    var gpwService = new GpwService();

    BrightLocalSuccess gpwReport = gpwService.Create(myGpwReport);
```
The returned BrightLocalSuccess entity above will have a report-id. You will want to persist this for later in order to run and get the report.

### Update Report

```csharp
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
    myGpwReport.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };

    var gpwService = new GpwService();

    BrightLocalSuccess gpwReport = gpwService.Update(myGpwReport);
```

### Get Report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalGpwReport gpwReport = gpwService.Get(reportId);
```

### Delete Report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalSuccess gpwReport = gpwService.Delete(reportId);
```

### Get All Reports

```csharp	
    var gpwService = new GpwService();

	BrightLocalGpwGetAllResults gpwGetAllResults = gpwService.GetAll();
```

### Run Report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalSuccess gpwReport = gpwService.Run(reportId);
```

### Get Report Results

```csharp	
    var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalGpwReportResults gpwReport = gpwService.GetReportResults(reportId);
```
