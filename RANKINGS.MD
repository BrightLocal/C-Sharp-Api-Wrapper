Batch Rankings Search
-----

### Fetch Rankings

```csharp
    List<RankingsSearch> searches = new List<RankingsSearch>();
    searches.Add(new RankingsSearch()
    {
        search_engine = "google",
        country = "USA",
        google_location = "New York, NY",
        search_term = "restaurant new york",
        urls = new List<string>() { "le-bernardin.com" },
        business_names = new List<string>() { "Le Bernardin" }
    });
    searches.Add(new RankingsSearch()
    {
        search_engine = "yahoo",
        country = "USA",
        google_location = "New York, NY",
        search_term = "restaurant new york",
        urls = new List<string>() { "le-bernardin.com" },
        business_names = new List<string>() { "Le Bernardin" }
    });


    api Api = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");
    batchApi batchRequest = new batchApi(Api);

    // Create a new batch
    int batchId = batchRequest.Create();
    var parameters = new api.Parameters();
            
    // Add jobs to batch
    foreach (var item in searches)
    {
        // Convert the searches list into parameters for the web requestt
        parameters = batchRequest.convertListToParameters(item);
        parameters.Add("batch-id", batchId);

        var jobId = Api.Post("v4/rankings/search", parameters);

        if (jobId.ResponseStatus == ResponseStatus.Completed)
        {
            dynamic job = JsonConvert.DeserializeObject(jobId.Content);
            if (job.success != "true")
            {
                string message = job.errors;
                var batchException = new ApplicationException(message, job.ErrorException);
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
    dynamic rankingResults = JsonConvert.DeserializeObject(results.Content);

    if (rankingResults.success == "true")
    {
        while (rankingResults.status != "Stopped" || rankingResults.status != "Finished")
        {
            Thread.Sleep(10000);
            results = batchRequest.GetResults(batchId);
            rankingResults = JsonConvert.DeserializeObject(results.Content);
        }
        return rankingResults;
    }
    else
    {
        const string message = "Error Retrieving batch results ";
        var batchException = new ApplicationException(message, results.ErrorException);
        throw batchException;
    }
```