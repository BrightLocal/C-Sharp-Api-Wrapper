
using System.Collections.Generic;

namespace BrightLocal.Examples_version2.Account_Methods
{
    public class locationExamples
    {
        public static BlSuccess Create()
        {
            var location = new Location();
            location.name = "Le Bernardin";
            location.url = "le-bernardin.com";
            location.businessCategoryId = 791;
            location.country = "USA";
            location.address1 = "155 Weest 51st Street";
            location.address2 = "";
            location.region = "NY"; // state or region
            location.city = "New York";
            location.postcode = "10019";
            location.telephone = "+1 212-554-1515";

            var locationService = new LocationService();

            BlSuccess newLocation = locationService.Create(location);
            return newLocation;
        }

        public static BlSuccess Update()
        {
            var location = new UpdateLocation();
            location.locationId = 1;
            location.name = "Le Bernardin";
            location.url = "le-bernardin.com";
            location.businessCategoryId = 791;
            location.country = "USA";
            location.address1 = "155 Weest 51st Street";
            location.address2 = "";
            location.region = "NY"; // state or region
            location.city = "New York";
            location.postcode = "10019";
            location.telephone = "+1 212-554-1515";

            var locationService = new LocationService();

            BlSuccess updateLocation = locationService.Update(location);
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
