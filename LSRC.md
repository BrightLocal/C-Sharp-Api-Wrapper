Local Search Rank Checker
-----

### Add Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("name", "Le Bernardin");            
            parameters.Add("schedule", "Adhoc");
            parameters.Add("search-terms", "Restaurant\nfood+nyc\ndelivery+midtown+manhattan");
            parameters.Add("website-addresses", "['le-bernardin.com', 'le-bernardin2.com']");
            parameters.Add("search-engines", "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local");

    var success = request.Post("v2/lsrc/add", parameters);    
```

### Update Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("campaign-id", "9907");
            parameters.Add("name", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("search-terms", "Restaurant\nfood+nyc\ndelivery+midtown+manhattan");
            parameters.Add("website-addresses", "['le-bernardin.com', 'le-bernardin2.com']");
            parameters.Add("search-engines", "google, google-mobile, google-local, yahoo, yahoo-local, bing, bing-local");

    var success = request.Post("v2/lsrc/update", parameters);    
```

### Delete Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("campaign-id", "9907");            

    var success = request.Delete("v2/lsrc/delete", parameters);    
```

### Get All Reports

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();            
    
    var results = request.Get("v2/lsrc/get-all", parameters); 
```

### Get Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("campaign-id", "50");    
    
    var results = request.Get("v2/lsrc/get", parameters); 
```

### Run Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("campaign-id", "50");

    var success = request.Post("v2/lsrc/run", parameters);
```

### Get Report History

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("campaign-id", "50");    
    
    var results = request.Get("/v2/lsrc/history/get", parameters); 
```

### Get Report Results

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("campaign-id", "9636");    
    
    var results = request.Get("v2/lsrc/results/get", parameters); 
```