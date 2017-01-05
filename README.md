![BrightLocal](https://github.com/BrightLocal/C-Sharp-Api-Wrapper/blob/master/Documentation/logo.png)


**BrightLocal API Wrapper Version 2.0**
For version 1.0 [Click Here](Documentation/README.md)

**BrightLocal API Services**

[Clients](#clients)  
[Locations](#locations)  
[Local Search Rank Checker](#local-search-rank-checker)  
[Local SEO Check-up](#local-seo-check-up)

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

    BrightLocalClient newClient = clientService.Create(myClient);
```

The returned BrightLocalClient entity above will have a client-id. You will want to persist this for later. When you create a location you will be able to assign it
to a client id (or not).

### Updating a client

```csharp
	var myClient = new UpdateClientOptions();
    myClient.clientId = 36447;
    myClient.name = "Le Bernardin";
    myClient.companyUrl = "le-bernardin.com";
    myClient.businessCategoryId = 791;

    var clientService = new ClientService();

    BrightLocalClient updateClient = clientService.Update(myClient);
```

### Deleting a client

```csharp
	var clientId = 1;
    var clientService = new ClientService();

    BrightLocalClient deleteClient = clientService.Delete(clientId);
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

    BrightLocalLocation newLocation = locationService.Create(myLocation);
```

The returned BrightLocalClient entity above will have a location-id. You will want to persist this for later. When you create a report you will be able to assign it
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

	BrightLocalLocation updateLocation = locationService.Update(myLocation);
```

### Deleting a location

```csharp
	var locationId = 1;
    var locationService = new LocationService();

    BrightLocalLocation deleteLocation = locationService.Delete(locationId);
          
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

    BrightLocalLsrc newLsrc = lsrcService.Create(myLsrc);
```

The returned BrightLocalClient entity above will have a campaign-id. You will want to persist this for later in order to run and get the report.

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

    BrightLocalLsrc updatedLsrc = lsrcService.Update(myLsrc);
```

### Deleting a report

```csharp
	var campaignId = 1;           
    var lsrcService = new LsrcService();

    BrightLocalLsrc deletedLsrc = lsrcService.Delete(campaignId);
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

	var lsrcResults = lsrcService.GetResults(myLsrc);
```

The LsrcService.GetResults method above currently returns a json object. In future releases we will have a entity BrightLocalLsrcResults.

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

    BrightLocalLscu newLscu = lscuService.Create(myLscu);
```

The returned BrightLocalLscu entity above will have a report-id. You will want to persist this for later when you get and run a report.

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

    BrightLocalLscu updateLscu = lscuService.Update(myLscu);
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

