Citation Tracker
-----

### Add Report

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();
        parameters.Add("report-name", "Sample Citation Tracking Report");
        parameters.Add("business-name", "Le Bernardin");
        parameters.Add("business-location", "NY, New York");
        parameters.Add("phone", "+1 212-554-1515");
        parameters.Add("website", "le-bernardin.com");
        parameters.Add("business-type", "Restaurant");            
        parameters.Add("state-code", "NY");           

var success = request.Post("v2/ct/add", parameters);
```

### Update Report

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();
        parameters.Add("report-name", "Sample Citation Tracking Report");
        parameters.Add("business-name", "Le Bernardin");
        parameters.Add("business-location", "NY, New York");
        parameters.Add("phone", "+1 212-554-1515");
        parameters.Add("website", "le-bernardin.com");
        parameters.Add("business-type", "Restaurant");
        parameters.Add("state-code", "NY");

var success = request.Post("v2/ct/update", parameters);
```

### Get Report

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();
        parameters.Add("report-id", "682");

var results = request.Get("v2/ct/get", parameters);
```

### Run Report

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();
        parameters.Add("report-id", "682");

var success = request.Put("v2/ct/run", parameters);
```

### Delete Report

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();
        parameters.Add("report-id", "682");

var success = request.Post("v2/ct/delete", parameters);
```

### Get All Reports

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();

var results = request.Get("v2/ct/get-all", parameters);
```

### Get Report Results

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();
        parameters.Add("report-id", "2457");

var results = request.Get("v2/ct/get-results", parameters);
```