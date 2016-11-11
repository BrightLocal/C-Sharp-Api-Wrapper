ReviewFlow Reports
-----

### Add Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();
            parameters.Add("report-name", "Sample Citation Tracking Report");
            parameters.Add("business-name", "Le Bernardin");            
            parameters.Add("contact-telephone", "+1 212-554-1515");
            parameters.Add("address1", "155 Weest 51st Street");
            parameters.Add("address2", "");
            parameters.Add("city", "New York");            
            parameters.Add("postcode", "10019");
            parameters.Add("country", "USA"); // USA only

    var success = request.Post("v4/rf/add", parameters);
```

### Update Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();
            parameters.Add("business-name", "Le Bernardin");
            parameters.Add("contact-telephone", "+1 212-554-1515");
 
    var success = request.Put("v4/rf/" + reportId + "", parameters);
```

### Get Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();

    var results = request.Get("v4/rf/" + reportId + "", parameters);
```

### Delete Report

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();

    var success = request.Delete("v4/rf/" + reportId + "", parameters);
```

### Get All Reports

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var parameters = new api.Parameters();

    var results = request.Get("v4/rf", parameters);
```

### Search Reports

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 1;
    var parameters = new api.Parameters();
            parameters.Add("q", "Le Bernardin");            

    var results = request.Get("v4/rf/search", parameters);
```

### Get Reviews

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 141;
    var parameters = new api.Parameters();

    var results = request.Get("v4/rf/" + reportId + "/reviews", parameters);
```

### Get Reviews Count

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 141;
    var parameters = new api.Parameters();

    var results = request.Get("v4/rf/" + reportId + "/reviews/count", parameters);
```

### Get Growth

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 141;
    var parameters = new api.Parameters();

    var growth = request.Get("v4/rf/" + reportId + "/reviews/growth", parameters);
```

### Get Directories

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 141;
    var parameters = new api.Parameters();

    var directories = request.Get("v4/rf/" + reportId + "/directories", parameters);
```

### Get Directory Stats

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 141;
    var parameters = new api.Parameters();

    var stats = request.Get("v4/rf/" + reportId + "/directories/stats", parameters);
```

### Get Star Counts

```csharp
    api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

    var reportId = 141;
    var parameters = new api.Parameters();

    var stars = request.Get("v4/rf/" + reportId + "/stars/count", parameters);
```

