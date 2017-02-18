﻿
using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class locationExamples
    {
        public static BlSuccess Create()
        {
            var myLocation = new LocationOptions();
            myLocation.name = "Le Bernardin";
            myLocation.url = "le-bernardin.com";
            myLocation.businessCategoryId = 791;
            myLocation.country = "USA";
            myLocation.address1 = "155 Weest 51st Street";
            myLocation.address2 = "";
            myLocation.region = "NY"; // state or region
            myLocation.city = "New York";
            myLocation.postcode = "10019";
            myLocation.telephone = "+1 212-554-1515";

            var locationService = new LocationService();

            BlSuccess newLocation = locationService.Create(myLocation);
            return newLocation;
        }

        public static BlSuccess Update()
        {
            var myLocation = new UpdateLocationOptions();
            myLocation.locationId = 1;
            myLocation.name = "Le Bernardin";
            myLocation.url = "le-bernardin.com";
            myLocation.businessCategoryId = 791;
            myLocation.country = "USA";
            myLocation.address1 = "155 Weest 51st Street";
            myLocation.address2 = "";
            myLocation.region = "NY"; // state or region
            myLocation.city = "New York";
            myLocation.postcode = "10019";
            myLocation.telephone = "+1 212-554-1515";

            var locationService = new LocationService();

            BlSuccess updateLocation = locationService.Update(myLocation);
            return updateLocation;
        }

        public static BlSuccess Delete()
        {
            var locationId = 1;
            var locationService = new LocationService();

            BlSuccess deleteLocation = locationService.Delete(locationId);
            return deleteLocation;
        }

        public static BlLocation Get()
        {
            var locationId = 1;
            var locationService = new LocationService();

            BlLocation getLocation = locationService.Get(locationId);
            return getLocation;
        }

        public static BlLocationSearch Search()
        {
            var searchQuery = "le-bernardin";
            var locationService = new LocationService();

            BlLocationSearch results = locationService.Search(searchQuery);
            return results;
        }
    }
}
