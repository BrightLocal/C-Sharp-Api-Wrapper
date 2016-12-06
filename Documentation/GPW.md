Google+ Local Wizard Report
-----

### Add Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

     var parameters = new api.Parameters();
            parameters.Add("report_name", "Sample SEO Check-Up Report");
            parameters.Add("business_names", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("day_of_month", "2");
            parameters.Add("report_type", "with");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state_code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("phone_number", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");

    var success = request.Post("v4/gpw/add", parameters);
```

### Update Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();
            parameters.Add("report_name", "Sample SEO Check-Up Report");
            parameters.Add("business_names", "Le Bernardin");
            parameters.Add("schedule", "Adhoc");
            parameters.Add("day_of_month", "2");
            parameters.Add("report_type", "with");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");
            parameters.Add("state_code", "NY");
            parameters.Add("postcode", "10019");
            parameters.Add("phone_number", "+1 212-554-1515");
            parameters.Add("country", "USA");
            parameters.Add("business-category", "Restaurant");
            parameters.Add("search-terms", "['restaurant manhattan', 'cafe new york']");        

    var success = request.Put("v4/gpw/" + reportId + "", parameters);
```

### Get Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();
     
    var results = request.Get("v4/gpw/" + reportId + "", parameters);
```

### Delete Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();
     
    var success = request.Delete("v4/gpw/" + reportId + "", parameters);
```

### Get All Reports

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
     
    var results = request.Get("v4/gpw", parameters);
```

### Run Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-id", "1");

    var success = request.Put("v4/gpw/run", parameters);
```

### Get Report Results

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();            

    var results = request.Get("v4/gpw/" + reportId + "/results", parameters);
```

