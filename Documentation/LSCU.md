Local Search Rank Checker
-----

### Add Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-name", "Sample SEO Check-Up Report");
            parameters.Add("business-names", "['Le Bernardin']");
            parameters.Add("website-address", "le-bernardin.com");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state-code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("telephone", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("primary-business-location", "NY, New York");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");

    var success = request.Post("v4/lscu", parameters);
```

### Update Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-id", "1");
            parameters.Add("postcode", "10019");
            parameters.Add("telephone", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("primary-business-location", "NY, New York");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");

    var success = request.Put("v4/lscu", parameters);
```

### Get Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-id", "860");

    var results = request.Get("v4/lscu", parameters);
```

### Run Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-id", "860");

    var success = request.Put("v4/lscu/run", parameters);
```

### Delete Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-id", "860");

    var success = request.Delete("v4/lscu", parameters);
```

### Search Reports

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("q", "Bodega Wine Bar");

    var results = request.Get("v4/lscu/search", parameters);
```