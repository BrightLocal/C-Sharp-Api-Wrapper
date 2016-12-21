Citation Burst
-----

### Create Campaign

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

string brief_description = "Born in Paris in 1972 by sibling duo Maguy and Gilbert Le Coze, Le Bernardin only served fish: Fresh, simple and prepared with respect. After receiving its first Michelin star in 1976, and two more in 1980, the Le Coze’s set to open Le Bernardin in New York in 1986.";
string full_description = "The restaurant has held three stars from the Michelin Guide since its 2005 New York launch and currently ranks 24 on the World’s 50 Best Restaurants list. The New York Zagat Guide has recognized Le Bernardin as top rated in the category of “Best Food” for the last nine consecutive years, and in 2015 was rated by the guide as New York City’s top restaurant for food and service.  Le Bernardin has earned seven James Beard Awards since 1998 including “Outstanding Restaurant of the Year,” “Top Chef in New York City,” “Outstanding Service,” “Outstanding Chef in the United States,” “Outstanding Pastry Chef,” “Outstanding Wine Service,” and “Best Restaurant Design” in 2012. 
Most recently, the Foundation named Maguy Le Coze as Outstanding ";

var parameters = new api.Parameters();
parameters.Add("campaign_name", "Sample Citation Burst Campaign");
parameters.Add("business_name", "Le Bernardin");
parameters.Add("website_address", "le-bernardin.com");
parameters.Add("campaign_country", "USA");
parameters.Add("campaign_city", "New York");
parameters.Add("campaign_state", "NY");
parameters.Add("business_category_id", 605);
parameters.Add("business_categories", "['restaurant', 'cafe']");
parameters.Add("address1", "155 West 51st Street");
parameters.Add("address2", "");
parameters.Add("city", "New York");
parameters.Add("region", "New York, USA");
parameters.Add("postcode", "10019");
parameters.Add("contact_name", "Hanane Moshe");
parameters.Add("contact_firstname", "Hanane");
parameters.Add("contact_telephone", "+1 212-554-1515";
parameters.Add("contact_email", "hananemo@gmail.com");      
parameters.Add("brief_description", brief_description);
parameters.Add("full_description", full_description);
parameters.Add("employees_number", 35);
parameters.Add("start_year", 1976);            
parameters.Add("working_hours_apply_to_all", 0);
parameters.Add("working_hours_mon_start", 0800);
parameters.Add("working_hours_mon_end", 2200);
parameters.Add("working_hours_tue_start", 0800);
parameters.Add("working_hours_tue_end", 2200);
parameters.Add("working_hours_wed_start", 0800);
parameters.Add("working_hours_wed_end", 2200);
parameters.Add("working_hours_thu_start", 0800);
parameters.Add("working_hours_thu_end", 2200);
parameters.Add("working_hours_fri_start", 0800);
parameters.Add("working_hours_fri_end", 2400);
parameters.Add("working_hours_sat_start", 1000);
parameters.Add("working_hours_sat_end", 2400);
parameters.Add("working_hours_sun_start", 1000);
parameters.Add("working_hours_sun_end", 2400);          

var success = request.Post("/v2/cb/create", parameters);
```

### Get Citations

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var campaignId = 1;
var parameters = new api.Parameters();
parameters.Add("campaign-id", campaignId);

var citations = request.Get("/v2/cb/citations", parameters);
```

### Confirm & Pay 

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var campaignId = 1;
var parameters = new api.Parameters();
parameters.Add("campaign-id", campaignId);
parameters.Add("package-id", "cb15");

var success = request.Post("/v2/cb/confirm-and-pay", parameters);
```

### Get Campaigns

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var parameters = new api.Parameters();

var campaigns = request.Get("/v2/cb/get-all", parameters);
```

### Get Campaign

```csharp
api request = new api("<INSERT_API_KEY>", "<INSERT_API_SECRET>");

var campaignId = 1;
var parameters = new api.Parameters();
parameters.Add("campaign-id", campaignId);

var campaigns = request.Get("/v2/cb/get", parameters);
```

