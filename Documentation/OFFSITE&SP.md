Batch Offsite SEO & Social Profiles
-----

### Fetch Offsite SEO for a Website

```csharp
api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
batchApi batchRequest = new batchApi(Api);

// Create a new batch
int batchId = batchRequest.Create();

var parameters = new api.Parameters();
parameters.Add("batch-id", batchId);
parameters.Add("website-url", "http://le-bernardin.com");   

var jobId = Api.Post("/v4/seo/offsite", parameters);

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

// Commit the batch, resturns true or false
bool commit = batchRequest.Commit(batchId);

// Poll for results. In a real world example you should do this in a background process, such as HangFire, or use the Task Parallel Library to create a BackGroundWorker Task.
// It is bad practice to use Thread.Sleep(). This is only for the example and will actually freeze the UI until the while loop is finished. 

var results = batchRequest.GetResults(batchId);
dynamic offsiteResults = JsonConvert.DeserializeObject(results.Content);

if (offsiteResults.success)
{
    while (offsiteResults.status != "Stopped" || offsiteResults.status != "Finished")
    {
        Thread.Sleep(10000);
        results = batchRequest.GetResults(batchId);
        offsiteResults = JsonConvert.DeserializeObject(results.Content);
    }
    return results;
}
else
{
    const string message = "Error Retrieving batch results ";
    var batchException = new ApplicationException(message, results.ErrorException);
    throw batchException;
}
```

### Fetch Details of the Socal Profiles of a Business


```csharp
api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
batchApi batchRequest = new batchApi(Api);

// Create a new batch
int batchId = batchRequest.Create();

var parameters = new api.Parameters();
parameters.Add("batch-id", batchId);
parameters.Add("website-url", "http://le-bernardin.com");
parameters.Add("fetch-twitter", "yes");
parameters.Add("fetch-facebook", "yes");
parameters.Add("fetch-foursqaure", "yes");
parameters.Add("business-names", "['Le Bernardin', 'Bernardin Cafe']");
parameters.Add("street-addess", "155 West 51st Street");
parameters.Add("city", "New York");
parameters.Add("state-code", "NY");
parameters.Add("telephone", "+1 212-554-1515");
parameters.Add("postcode", "10019");
parameters.Add("country", "USA");

var jobId = Api.Post("/v4/social/profiles", parameters);

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

// Commit the batch, resturns true or false
bool commit = batchRequest.Commit(batchId);

// Poll for results. In a real world example you should do this in a background process, such as HangFire, or use the Task Parallel Library to create a BackGroundWorker Task.
// It is bad practice to use Thread.Sleep(). This is only for the example and will actually freeze the UI until the while loop is finished. 

var results = batchRequest.GetResults(batchId);
dynamic socialResults = JsonConvert.DeserializeObject(results.Content);

if (socialResults.success)
{
    while (socialResults.status != "Stopped" || socialResults.status != "Finished")
    {
        Thread.Sleep(10000);
        results = batchRequest.GetResults(batchId);
        socialResults = JsonConvert.DeserializeObject(results.Content);
    }
    return results;
}
else
{
    const string message = "Error Retrieving batch results ";
    var batchException = new ApplicationException(message, results.ErrorException);
    throw batchException;
}
```

