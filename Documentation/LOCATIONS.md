Locations
-----

### Creating a Location

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
           parameters.Add("name", "Le Bernardin");
           parameters.Add("url", "http://le-bernardin.com");
           parameters.Add("business-category-id", "605");
           parameters.Add("country", "USA"); // 3 Letter iso code
           parameters.Add("address1", "155 Weest 51st Street");
           parameters.Add("address2", "");
           parameters.Add("region", "NY"); // State or Region
           parameters.Add("city", "New York");
           parameters.Add("postcode", "10019");
           parameters.Add("telephone", "+1 212-554-1515");

    var success = request.Post("v1/clients-and-locations/locations/", parameters);
```

### Update a location

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

	var locationId = 1;
    var parameters = new api.Parameters();
           parameters.Add("name", "Le Bernardin");
           parameters.Add("url", "http://le-bernardin.com");
           parameters.Add("business-category-id", "605");
           parameters.Add("country", "USA"); // 3 Letter iso code
           parameters.Add("address1", "155 Weest 51st Street");
           parameters.Add("address2", "");
           parameters.Add("region", "NY"); // State or Region
           parameters.Add("city", "New York");
           parameters.Add("postcode", "10019");
           parameters.Add("telephone", "+1 212-554-1515");

    var success = request.Put("v1/clients-and-locations/locations/" + locationId + "", parameters);
```

### Delete a Location

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var locationId = 1;
    var parameters = new api.Parameters();

    var success = request.Delete("v1/clients-and-locations/locations/" + locationId + "", parameters);
```

### Get Location

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var locationId = 1;
    var parameters = new api.Parameters();

    var success = request.Get("v1/clients-and-locations/locations/" + locationId + "", parameters);
```
### Search Locations

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
           parameters.Add("q", "My Sample Query");

    var success = request.Get("v1/clients-and-locations/locations/search", parameters);
```
