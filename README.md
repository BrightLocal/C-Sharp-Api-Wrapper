![BrightLocal](https://github.com/BrightLocal/C-Sharp-Api-Wrapper/blob/master/Documentation/logo.png)


**BrightLocal API Wrapper Version 2.0**
For version 1.0 [Click Here](Documentation/README.md)

**BrightLocal API Services**

[Clients](#clients)  
[Locations](#locations)  
[Local Search Rank Checker](#local-search-rank-checker)  
[Local SEO Check-up](#local-seo-check-up)  
[Citation Tracker](#citation-tracker)  
[Citation Burst](#citation-burst)  
[ReviewFlow Reports](#reviewflow-reports)  
[Google+ Local Wizard Reports](#google-plus-local-wizard-reports)  

Quick Start
-----------

It is recommended that you install BrightLocal via NuGet ` nuget Install-Package BrightLocal`. | https://www.nuget.org/packages/BrightLocal/1.0.0/

```csharp
   nuget Install-Package BrightLocal
```

Next you will need to provide BrightLocal with your api key & api secret. There are currently 2 ways to do this:

a) Add an AppSetting with your api key to your config (this is the easiest way and will work throughout the app on every request) 

```xml
	<appSettings>
	...
		<add key="BrightLocalApiKey" value="[your api key here]" />
		<add key="BrightLocalApiSecret" value="[your api secret here]" />
	...
	</appSettings>
```

b) In your application initialization, call this method (this is a programmatic way, but you only have to do it once during startup)

```csharp
	BrightLocalConfiguration.SetApiCredentials("[your api key here]", "[your api secret here]");
```

c) In any of the service constructors, you can optionally pass the api key & api secret (will be assigned that apikey for the life of the service instance).

```csharp
	var clientService = new ClientService("[your api key here]", "[your api secret here]");
```

Clients
-----

### Adding a client

```csharp
	var myClient = new ClientOptions();
    myClient.name = "Le Bernardin";
    myClient.companyUrl = "le-bernardin.com";
    myClient.businessCategoryId = 791;

    var clientService = new ClientService();

    BrightLocalSuccess newClient = clientService.Create(myClient);
```

The returned BrightLocalSuccess entity above will have a client-id. You will want to persist this for later. When you create a location you will be able to assign it
to a client id (or not).

### Updating a client

```csharp
	var myClient = new UpdateClientOptions();
    myClient.clientId = 36447;
    myClient.name = "Le Bernardin";
    myClient.companyUrl = "le-bernardin.com";
    myClient.businessCategoryId = 791;

    var clientService = new ClientService();

    BrightLocalSuccess updateClient = clientService.Update(myClient);
```

### Deleting a client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BrightLocalSuccess deleteClient = clientService.Delete(clientId);
```

### Getting a client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BrightLocalClient client = clientService.Get(clientId);
```

### Searching for a client

```csharp
	var searchQuery = "le-bernardin";
    var clientService = new ClientService();

    BrightLocalClientSearch results = clientService.Search(searchQuery);
```


Locations
-----

### Adding a location

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

The returned BrightLocalSuccess entity above will have a location-id. You will want to persist this for later. When you create a report you will be able to assign it
to a location id (or not).

### Updating a location

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

### Deleting a location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BrightLocalSuccess deleteLocation = locationService.Delete(locationId);          
```

### Getting a location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BrightLocalLocation getLocation = locationService.Get(locationId);
```

### Searching for a location

```csharp
	var searchQuery = "le-bernardin";
    var locationService = new LocationService();

    BrightLocalLocationSearch results = locationService.Search(searchQuery); 
```

Local Search Rank Checker
-----

### Adding a report

```csharp
	var myLsrc = new LsrcOptions();
    myLsrc.name = "Le Bernardin";
    myLsrc.websiteAddresses = new List<string>() {"le-bernardin.com", "www.le-bernadin.com"};
    myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
    myLsrc.schedule = "Adhoc";
    myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";
          
    var lsrcService = new LsrcService();

    BrightLocalSuccess newLsrc = lsrcService.Create(myLsrc);
```

The returned BrightLocalSuccess entity above will have a campaign-id. You will want to persist this for later in order to run and get the report.

### Updating a report

```csharp
	var myLsrc = new UpdateLsrcOptions();
    myLsrc.campaignId = 1;
    myLsrc.name = "Le Bernardin";
    myLsrc.websiteAddresses = new List<string>() { "le-bernardin.com", "www.le-bernadin.com" };
    myLsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
    myLsrc.schedule = "Adhoc";
    myLsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";

    var lsrcService = new LsrcService();

    BrightLocalSuccess updatedLsrc = lsrcService.Update(myLsrc);
```

### Deleting a report

```csharp
	var campaignId = 1;           
    var lsrcService = new LsrcService();

    BrightLoBrightLocalSuccesscalLsrc deletedLsrc = lsrcService.Delete(campaignId);
```

### Getting all reports

```csharp
	var lsrcService = new LsrcService();

    BrightLocalGetAllResults lsrcList = lsrcService.GetAll();;
```

### Getting a report

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BrightLocalLsrcReport myLsrc = lsrcService.Get(campaignId);
```

### Running a report

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BrightLocalLsrc myLsrc = lsrcService.Run(campaignId);
```

### Get report history

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BrightLocalLsrcHistory lsrcHistory = lsrcService.GetHistory(campaignId);
```

### Get report results

```csharp
	var myLsrc = new GetResultsLsrcOptions();
	myLsrc.campaignId = 1;
            
	var lsrcService = new LsrcService();

	BrightLocalLsrcReportResults lsrcResults = lsrcService.GetResults(myLsrc);
```


Local SEO Check-up
-----

### Adding a report

```csharp
	LscuOptions myLscu = new LscuOptions();
    myLscu.reportName = "Sample SEO Chek-Up Report";
    myLscu.businessNames = new List<string>() {"Le Bernardin", "Le Bernardin Cafe"};
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
    myLscu.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };       

    var lscuService = new LscuService();

    BrightLocalSuccess newLscu = lscuService.Create(myLscu);
```

The returned BrightLocalSuccess entity above will have a report-id. You will want to persist this for later when you get and run a report.

### Supplying Local Directory URLs (see local-directory-urls parameter)

```csharp
    LscuOptions myLscu = new LscuOptions();
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

### Updating a report

```csharp
	UpdateLscuOptions myLscu = new UpdateLscuOptions();
    myLscu.reportName = "Sample SEO Chek-Up Report";
    myLscu.businessNames = new List<string>() { "Le Bernardin", "Le Bernardin Cafe" };
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
    myLscu.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };

    var lscuService = new LscuService();

    BrightLocalSuccess updateLscu = lscuService.Update(myLscu);
```

### Getting a report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BrightLocalLscuReport lscuReport = lscuService.Get(reportId);
```

### Running a report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    var success = lscuService.Run(reportId);
```
The returned success entity above is of type string. Success or Failure with errors.

### Deleting a report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    var success = lscuService.Delete(reportId);
```
The returned success entity above is of type string. Success or Failure with errors.

### Searching for a report

```csharp
	var searchQuery = "Bodega Wine Bar";
    var lscuService = new LscuService();

    BrightLocalLscuSearch lscuSearch = lscuService.Search(searchQuery);
```

Citation Tracker
-----

### Adding a report

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

### Updating a report

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

### Getting a report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BrightLocalCitationTrackerReport myCt = citationTrackerService.Get(reportId);
```

### Running a report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BrightLocalSuccess myCt = citationTrackerService.Run(reportId);
```

### Deleting a report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BrightLocalSuccess myCt = citationTrackerService.Delete(reportId);
```

### Getting all reports

```csharp	
    var citationTrackerService = new CitationTrackerService();

    BrightLocalCtGetAllResults ctResults = citationTrackerService.GetAll();
```

### Getting report results

```csharp	
    var reportId = 1;
    var citationTrackerService = new CitationTrackerService();

    BrightLocalCitationTrackerResults ctResults = citationTrackerService.GetReportResults(reportId);
```

Citation Burst
-----

### Creating a campaign

```csharp
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
```
The returned BrightLocalSuccess entity above will have a campaign-id. You will want to persist this for later in order to get citations, confirm & pay, etc.

### Updating a campaign

```csharp
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
```

### Uploading an image

```csharp
	CbUploadImage image = new CbUploadImage();
    image.campaignId = 1;
    image.file = "/path/to/image.jpg";
    image.imageType = "logo";

    var citationBurstService = new CitationBurstService();

    BrightLocalSuccess cbImage = citationBurstService.UploadImage(image);
```

### Getting citations

```csharp
	int campaingId = 1;
    var citationBurstService = new CitationBurstService();

    BrightLocalCitations citations = citationBurstService.GetCitations(campaingId);
```

### Confirm & Pay for citation Campaign

```csharp
	BrightLocalCbPayOptions confirmPay = new BrightLocalCbPayOptions();
    confirmPay.campaign_id = 1;
    confirmPay.package_id = "cb15";

    var citationBurstService = new CitationBurstService();

    BrightLocalSuccess confirm = citationBurstService.ConfirmAndPay(confirmPay);
```

### Getting all campaigns

```csharp	
    var citationBurstService = new CitationBurstService();

    BrightLocalCbAllCampaigns results = citationBurstService.GetCampaigns();
```

### Getting campaign details

```csharp	
    int campaignId = 1;
    var citationBurstService = new CitationBurstService();

    BrightLocalCbCampaign results = citationBurstService.GetCampaign(campaignId);
```

### Getting credits balance

```csharp	
    var citationBurstService = new CitationBurstService();

    BrightLocalSuccess credits = citationBurstService.GetCredits();
```

ReviewFLow Reports
-----

### Adding a report

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

### Updating a report

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

### Getting a report

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfReport reviewReport = rfService.Get(reportId);
```

### Deleting a report

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalSuccess deleteReport = rfService.Delete(reportId);
```

### Getting all reports

```csharp
	var rfService = new ReviewFlowService();

    BrightLocalRfGetAll results = rfService.GetAll();
```

### Searching for a report

```csharp
	string query = "New York";
    var rfService = new ReviewFlowService();

    BrightLocalRfGetAll results = rfService.Search(query);
```

### Getting Reviews

```csharp
	var myReviewReport = new RfGetReviewsOptions();
    myReviewReport.reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfReviews reviews = rfService.GetReviews(myReviewReport);
```

### Getting Reviews Count

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalSuccess reviewCount = rfService.GetReviewCount(reportId);
```

### Getting Growth

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalSuccess reviewGrowth = rfService.GetGrowth(reportId);
```

### Getting Directories

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfDirectories reviewDirectories = rfService.GetDirectories(reportId);
```

### Getting Directory Stats

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfDirectoryStats reviewDirectoryStats = rfService.GetDirectoryStats(reportId);
```

### Getting Star Counts

```csharp	
    int reportId = 1;
    var rfService = new ReviewFlowService();

    BrightLocalRfStarCounts reviewStarCount = rfService.GetStarCount(reportId);
```

Google Plus Local Wizard Reports
-----

### Adding a report

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

### Updating a report

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

### Getting a report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalGpwReport gpwReport = gpwService.Get(reportId);
```

### Deleting a report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalSuccess gpwReport = gpwService.Delete(reportId);
```

### Getting all reports

```csharp	
    var gpwService = new GpwService();

	BrightLocalGpwGetAllResults gpwGetAllResults = gpwService.GetAll();
```

### Running a report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalSuccess gpwReport = gpwService.Run(reportId);
```

### Getting report results

```csharp	
    var reportId = 1;
    var gpwService = new GpwService();

    BrightLocalGpwReportResults gpwReport = gpwService.GetReportResults(reportId);
```