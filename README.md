![BrightLocal](https://github.com/BrightLocal/C-Sharp-Api-Wrapper/blob/master/Documentation/logo.png)


**BrightLocal API Wrapper Version 2.0**
For version 1.0 [Click Here](Documentation/README.md)

**BrightLocal API Services**

[Clients](#clients) 
[Locations](#locations)

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

    List<BrightLocalClient> results = clientService.Search(searchQuery); // returns a list of type BrightLocalClient
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

    List<BrightLocalLocation> results = locationService.Search(searchQuery); // returns a list of type BrightLocalLocation
```

