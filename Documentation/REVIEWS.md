Batch Reviews
-----

### Fetch Reviews (by profile URL)

```csharp
List<string> profileUrls = new List<string>();
profileUrls.Add("https://plus.google.com/114222978585544488148/about?hl=en");
profileUrls.Add("https://plus.google.com/117313296997732479889/about?hl=en");
profileUrls.Add("https://plus.google.com/111550668382222753542/about?hl=en");

api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
batchApi batchRequest = new batchApi(Api);

// Create a new batch
int batchId = batchRequest.Create();


// Add jobs to batch
foreach (var item in profileUrls)
{
    var parameters = new api.Parameters();
    parameters.Add("batch-id", batchId);
    parameters.Add("profile-url", item);
    parameters.Add("country", "USA");

    var jobId = Api.Post("/v4/ld/fetch-reviews", parameters);

    if (jobId.ResponseStatus == ResponseStatus.Completed)
    {
        dynamic job = JsonConvert.DeserializeObject(jobId.Content);
        if (!job.success)
        {
            string message = "Error adding job";
            var batchException = new ApplicationException(message + job.errors, job.ErrorException);
            throw batchException;
        }
    }
    else
    {
        throw new ApplicationException(jobId.ErrorMessage);
    }
}
// Commit the batch, resturns true or false
bool commit = batchRequest.Commit(batchId);

// Poll for results. In a real world example you should do this in a backgroud process, such as HangFire,  or use the Task Parallel Library to create a BackGroundWorker Task.
// It is bad practice to use Thread.Sleep(). This is only for the example and will actually freeze the UI until the while loop is finished. 

var results = batchRequest.GetResults(batchId);
dynamic reviewResults = JsonConvert.DeserializeObject(results.Content);

if (reviewResults.success)
{
    while (reviewResults.status != "Stopped" || reviewResults.status != "Finished")
    {
        Thread.Sleep(10000);
        results = batchRequest.GetResults(batchId);
        reviewResults = JsonConvert.DeserializeObject(results.Content);
    }
    return reviewResults;
}
else
{
    const string message = "Error Retrieving batch results ";
    var batchException = new ApplicationException(message + rankingResults.errors, results.ErrorException);
    throw batchException;
}
```

### Fetch Reviews (by business data)

```csharp
List<string> localDirectories = new List<string>();
localDirectories.Add("google");
localDirectories.Add("facebook");
localDirectories.Add("yahoo");

api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
batchApi batchRequest = new batchApi(Api);

// Create a new batch
int batchId = batchRequest.Create();

// Add jobs to batch
foreach (var item in localDirectories)
{    
    var parameters = new api.Parameters();
    parameters.Add("batch-id", batchId);
    parameters.Add("business-names", "Le Bernardin\nLe Bernardin Cafe");
    parameters.Add("city", "New York");
    parameters.Add("postcode", "10019");
    parameters.Add("local-directory", item);
    parameters.Add("country", USA);    

    var jobId = Api.Post("/v4/ld/fetch-reviews-by-business-data", parameters);

    if (jobId.ResponseStatus == ResponseStatus.Completed)
    {
        dynamic job = JsonConvert.DeserializeObject(jobId.Content);
        if (!job.success)
        {
            string message = "Error adding job";
            var batchException = new ApplicationException(message + job.errors, job.ErrorException);
            throw batchException;
        }
    }
    else
    {
        throw new ApplicationException(jobId.ErrorMessage);
    }
}
// Commit the batch, resturns true or false
bool commit = batchRequest.Commit(batchId);

// Poll for results. In a real world example you should do this in a backgroud process, such as HangFire,  or use the Task Parallel Library to create a BackGroundWorker Task.
// It is bad practice to use Thread.Sleep(). This is only for the example and will actually freeze the UI until the while loop is finished. 

var results = batchRequest.GetResults(batchId);
dynamic reviewResults = JsonConvert.DeserializeObject(results.Content);

if (reviewResults.success)
{
    while (reviewResults.status != "Stopped" || reviewResults.status != "Finished")
    {
        Thread.Sleep(10000);
        results = batchRequest.GetResults(batchId);
        reviewResults = JsonConvert.DeserializeObject(results.Content);
    }
    return reviewResults;
}
else
{
    const string message = "Error Retrieving batch results ";
    var batchException = new ApplicationException(message + rankingResults.errors, results.ErrorException);
    throw batchException;
}
```
