**BrightLocal API Wrapper Version 2.0**

For documentation for version 1.0 [click here](Documentation/README.md).

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
	BlConfiguration.SetApiCredentials("[your API key here]", "[your api secret here]");
```

3) In any of the service constructors, you can optionally pass the API key & API secret (will be assigned that apikey for the life of the service instance).

```csharp
	var clientService = new ClientService("[your api key here]", "[your api secret here]");
```

Clients
-----

### Add Client

```csharp
	var client = new Client();
    client.name = "Le Bernardin";
    client.companyUrl = "le-bernardin.com";
    client.businessCategoryId = 791;

    var clientService = new ClientService();

    BlSuccess newClient = clientService.Create(client);
```

The returned BlSuccess entity above will have a client-id. You will want to persist this for later. When you create a location you will be able to optionally assign it to a client ID.

### Update Client

```csharp
	var client = new UpdateClient();
    client.clientId = 36447;
    client.name = "Le Bernardin";
    client.companyUrl = "le-bernardin.com";
    client.businessCategoryId = 791;

    var clientService = new ClientService();

    BlSuccess updateClient = clientService.Update(client);
```

### Delete Client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BlSuccess deleteClient = clientService.Delete(clientId);
```

### Get Client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BlClient client = clientService.Get(clientId);
```

### Search Clients

```csharp
	var searchQuery = "le-bernardin";
    var clientService = new ClientService();

    BlClientSearch results = clientService.Search(searchQuery);
```


Locations
-----

### Add Location

```csharp
	var location = new Location();
    location.name = "Le Bernardin";
    location.url = "le-bernardin.com";
    location.businessCategoryId = 791;
    location.country = "USA";
    location.address1 = "155 Weest 51st Street";
    location.address2 = "";
    location.region = "NY"; // state or region
    location.city = "New York";
    location.postcode = "10019";
    location.telephone = "+1 212-554-1515";

    var locationService = new LocationService();

    var BlSuccess = locationService.Create(location);
```

The returned BlSuccess entity above will have a location-id. You will want to persist this for later. When you create a report you will be able to optionally assign it to a location id.

### Update Location

```csharp
	var location = new UpdateLocation();
	location.locationId = 1;
	location.name = "Le Bernardin";
	location.url = "le-bernardin.com";
	location.businessCategoryId = 791;
	location.country = "USA";
	location.address1 = "155 Weest 51st Street";
	location.address2 = "";
	location.region = "NY"; // state or region
	location.city = "New York";
	location.postcode = "10019";
	location.telephone = "+1 212-554-1515";

	var locationService = new LocationService();

	BlSuccess updateLocation = locationService.Update(location);
```

### Delete Location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BlSuccess deleteLocation = locationService.Delete(locationId);          
```

### Get Location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BlLocation getLocation = locationService.Get(locationId);
```

### Search Locations

```csharp
	var searchQuery = "le-bernardin";
    var locationService = new LocationService();

    BlLocationSearch results = locationService.Search(searchQuery); 
```

Local Search Rank Checker
-----

### Add Report

```csharp
	var lsrc = new Lsrc();
    lsrc.name = "Le Bernardin";
    lsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() {"le-bernardin.com", "www.le-bernadin.com"});
    lsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
    lsrc.schedule = "Adhoc";
    lsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";
          
    var lsrcService = new LsrcService();

    BlSuccess newLsrc = lsrcService.Create(lsrc);
```

The returned BlSuccess entity above will have a campaign-id. You will want to persist this for later in order to run and fetch the report.

### Update Report

```csharp
	var lsrc = new UpdateLsrc();
    lsrc.campaignId = 1;
    lsrc.name = "Le Bernardin";
    lsrc.websiteAddresses = JsonConvert.SerializeObject(new List<string>() { "le-bernardin.com", "www.le-bernadin.com" });
    lsrc.searchTerms = "Restaurant, food+nyc, delivery+midtown+manhattan";
    lsrc.schedule = "Adhoc";
    lsrc.searchEngines = "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local";

    var lsrcService = new LsrcService();

    BlSuccess updatedLsrc = lsrcService.Update(lsrc);
```

### Delete Report

```csharp
	var campaignId = 1;           
    var lsrcService = new LsrcService();

    BrightLoBlSuccesscalLsrc deletedLsrc = lsrcService.Delete(campaignId);
```

### Get Reports

```csharp
	var lsrcService = new LsrcService();

    BlGetAllResults lsrcList = lsrcService.GetAll();;
```

### Get Report

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BlLsrcReport lsrc = lsrcService.Get(campaignId);
```

### Run Report

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BlLsrc lsrc = lsrcService.Run(campaignId);
```

### Get Report History

```csharp
	var campaignId = 1;
    var lsrcService = new LsrcService();

    BlLsrcHistory lsrcHistory = lsrcService.GetHistory(campaignId);
```

### Get Report Results

```csharp
	var lsrc = new GetResultsLsrc();
	lsrc.campaignId = 1;
            
	var lsrcService = new LsrcService();

	BlLsrcReportResults lsrcResults = lsrcService.GetResults(lsrc);
```


Local SEO Check-up
-----

### Add Report

```csharp
	Lscu lscu = new Lscu();
    lscu.reportName = "Sample SEO Chek-Up Report";
    lscu.businessNames = JsonConvert.SerializeObject(new List<string>() {"Le Bernardin", "Le Bernardin Cafe"});
    lscu.websiteAddress = "le-bernardin.com";
    lscu.address1 = "155 Weest 51st Street";
    lscu.address2 = "";
    lscu.city = "New York";
    lscu.stateCode = "NY";
    lscu.postcode = "10019";
    lscu.telephone = "+1 212-554-1515";
    lscu.country = "USA";
    lscu.businessCategory = "Restaurant";
    lscu.primaryBusinessLocation = "NY, New York";
    lscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });       

    var lscuService = new LscuService();

    BlSuccess newLscu = lscuService.Create(lscu);
```

The returned BlSuccess entity above will have a report-id. You will want to persist this for later when you get and run a report.

### Supplying Local Directory URLs (see local-directory-urls parameter)

```csharp
    lscu.localDirectoryUrls = new LocalDirectoryUrls();
	lscu.localDirectoryUrls.Add(
        "citysearch",
        new DirectoryUrls
        {
            url = "http://www.yelp.co.uk/biz/greens-restaurant-san-francisco-3",
            include = "yes"
        });
    lscu.localDirectoryUrls.Add(
        "dexknows",
        new DirectoryUrls
        {
            url = "",
            include = "yes"
        });
```

### Update Report

```csharp
	UpdateLscu lscu = new UpdateLscu();
	lscu.reportId = 1;
    lscu.reportName = "Sample SEO Chek-Up Report";
    lscu.businessNames =  JsonConvert.SerializeObject(new List<string>() { "Le Bernardin", "Le Bernardin Cafe" });
    lscu.websiteAddress = "le-bernardin.com";
    lscu.address1 = "155 Weest 51st Street";
    lscu.address2 = "";
    lscu.city = "New York";
    lscu.stateCode = "NY";
    lscu.postcode = "10019";
    lscu.telephone = "+1 212-554-1515";
    lscu.country = "USA";
    lscu.businessCategory = "Restaurant";
    lscu.primaryBusinessLocation = "NY, New York";
    lscu.searchTerms = JsonConvert.SerializeObject(new List<string>() { "restaurant manhattan", "cafe new york" });

    var lscuService = new LscuService();

    BlSuccess updateLscu = lscuService.Update(lscu);
```

### Get Report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BlLscuReport lscuReport = lscuService.Get(reportId);
```

### Run Report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BlSuccess success = lscuService.Run(reportId);
```
The returned success entity above is of type string. Success or Failure with errors.

### Delete Report

```csharp
	var reportId = 1;
    var lscuService = new LscuService();

    BlSuccess success = lscuService.Delete(reportId);
```
The returned success entity above is of type string. Success or Failure with errors.

### Search Reports

```csharp
	var searchQuery = "Bodega Wine Bar";
    var lscuService = new LscuService();

    BlLscuSearch lscuSearch = lscuService.Search(searchQuery);
```

Citation Tracker
-----

### Add Report

```csharp
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
```
The returned BlSuccess entity above will have a report-id. You will want to persist this for later in order to run and get the report.

### Update Report

```csharp
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
```

### Get Report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BlCitationTrackerReport ct = citationTrackerService.Get(reportId);
```

### Run Report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BlSuccess ct = citationTrackerService.Run(reportId);
```

### Delete Report

```csharp
	int reportId = 682;

    var citationTrackerService = new CitationTrackerService();

    BlSuccess ct = citationTrackerService.Delete(reportId);
```

### Get Reports

```csharp	
    var citationTrackerService = new CitationTrackerService();

    BlCtGetAllResults ctResults = citationTrackerService.GetAll();
```

### Get Report Results

```csharp	
    var reportId = 1;
    var citationTrackerService = new CitationTrackerService();

    BlCitationTrackerResults ctResults = citationTrackerService.GetReportResults(reportId);
```

Citation Burst
-----

### Create Campaign

```csharp
	string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Cozes set to open Le Bernardin in New York in 1986.";
    string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the Worlds 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of Best Food for the last nine consecutive years, and in 2015 was rated by the guide as New York Citys top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including Outstanding Restaurant of the Year, Top Chef in New York City, Outstanding Service, Outstanding Chef in the United States, Outstanding Pastry Chef, Outstanding Wine Service, and Best Restaurant Design in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

    CitationBurst cb = new CitationBurst();            
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

    var CitationBurstService = new CitationBurstService();

    BlSuccess newCb = CitationBurstService.Create(cb);
```
The returned BlSuccess entity above will have a campaign-id. You will want to persist this for later in order to get citations, confirm & pay, etc.

### Update Campaign

```csharp
	string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Cozes set to open Le Bernardin in New York in 1986.";
    string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the Worlds 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of Best Food for the last nine consecutive years, and in 2015 was rated by the guide as New York Citys top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including Outstanding Restaurant of the Year, Top Chef in New York City, Outstanding Service, Outstanding Chef in the United States, Outstanding Pastry Chef, Outstanding Wine Service, and Best Restaurant Design in 2012. Most recently, the Foundation named Maguy Le Coze as Outstanding.";

    UpdateCitationBurst cb = new UpdateCitationBurst();
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

    var CitationBurstService = new CitationBurstService();

    BlSuccess newCb = CitationBurstService.Update(cb);
```

### Upload Image

```csharp
	CbUploadImage image = new CbUploadImage();
    image.campaignId = 1;
    image.file = "/path/to/image.jpg";
    image.imageType = "logo";

    var CitationBurstService = new CitationBurstService();

    BlSuccess cbImage = CitationBurstService.UploadImage(image);
```

### Get Citations

```csharp
	int campaingId = 1;
    var CitationBurstService = new CitationBurstService();

    BlCitations citations = CitationBurstService.GetCitations(campaingId);
```

### Confirm & Pay for Citation Campaign

```csharp
	BlCbPay confirmPay = new BlCbPay();
    confirmPay.campaign_id = 1;
    confirmPay.package_id = "cb15";

    var CitationBurstService = new CitationBurstService();

    BlSuccess confirm = CitationBurstService.ConfirmAndPay(confirmPay);
```

### Getting All Campaigns

```csharp	
    var CitationBurstService = new CitationBurstService();

    BlCbAllCampaigns results = CitationBurstService.GetCampaigns();
```

### Get Campaign Details

```csharp	
    int campaignId = 1;
    var CitationBurstService = new CitationBurstService();

    BlCbCampaign results = CitationBurstService.GetCampaign(campaignId);
```

### Get Credits Balance

```csharp	
    var CitationBurstService = new CitationBurstService();

    BlSuccess credits = CitationBurstService.GetCredits();
```

ReviewFLow Reports
-----

### Add Report

```csharp
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
```

The returned BlSuccess entity above will have a report-id. You will want to persist this for later when you get a report.

### Update Report

```csharp
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
```

### Get Report

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BlRfReport reviewReport = rfService.Get(reportId);
```

### Delete Report

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BlSuccess deleteReport = rfService.Delete(reportId);
```

### Get All Reports

```csharp
	var rfService = new ReviewFlowService();

    BlRfGetAll results = rfService.GetAll();
```

### Search Reports

```csharp
	string query = "New York";
    var rfService = new ReviewFlowService();

    BlRfGetAll results = rfService.Search(query);
```

### Get Reviews

```csharp
	var reviewReport = new RfGetReviews();
    reviewReport.reportId = 1;
    var rfService = new ReviewFlowService();

    BlRfReviews reviews = rfService.GetReviews(reviewReport);
```

### Get Review Counts

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BlSuccess reviewCount = rfService.GetReviewCount(reportId);
```

### Get Growth

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BlSuccess reviewGrowth = rfService.GetGrowth(reportId);
```

### Get Directories

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BlRfDirectories reviewDirectories = rfService.GetDirectories(reportId);
```

### Get Directory Stats

```csharp
	int reportId = 1;
    var rfService = new ReviewFlowService();

    BlRfDirectoryStats reviewDirectoryStats = rfService.GetDirectoryStats(reportId);
```

### Get Star Counts

```csharp	
    int reportId = 1;
    var rfService = new ReviewFlowService();

    BlRfStarCounts reviewStarCount = rfService.GetStarCount(reportId);
```

Google Plus Local Wizard Reports
-----

### Add Report

```csharp
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
    gpwReport.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };

    var gpwService = new GpwService();

    BlSuccess gpwReport = gpwService.Create(gpwReport);
```
The returned BlSuccess entity above will have a report-id. You will want to persist this for later in order to run and get the report.

### Update Report

```csharp
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
    gpwReport.searchTerms = new List<string>() { "restaurant manhattan", "cafe new york" };

    var gpwService = new GpwService();

    BlSuccess gpwReport = gpwService.Update(gpwReport);
```

### Get Report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BlGpwReport gpwReport = gpwService.Get(reportId);
```

### Delete Report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BlSuccess gpwReport = gpwService.Delete(reportId);
```

### Get All Reports

```csharp	
    var gpwService = new GpwService();

	BlGpwGetAllResults gpwGetAllResults = gpwService.GetAll();
```

### Run Report

```csharp
	var reportId = 1;
    var gpwService = new GpwService();

    BlSuccess gpwReport = gpwService.Run(reportId);
```

### Get Report Results

```csharp	
    var reportId = 1;
    var gpwService = new GpwService();

    BlGpwReportResults gpwReport = gpwService.GetReportResults(reportId);
```
