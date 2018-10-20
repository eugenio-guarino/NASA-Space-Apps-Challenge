using System;
using System.Collections.Generic;
using System.Text;

using RestSharp;

namespace LivingQuality.Models
{
    class AirQualityAPI
    {
        // API Documentation: https://aqicn.org/json-api/doc/
        private string api_Url = "https://api.waqi.info";

        // city and token
        private string api_CityFeedUrl = "https://api.waqi.info/feed/{0}/?token={1}";
        // lat, long and token
        private string api_GeolocalisedUrl = "https://api.waqi.info/feed/geo:{0};{1}/?token={2}";
        // token and keyword
        private string api_Search = "https://api.waqi.info/search/?token={0}&keyword={1}";

        private string apiToken = null;

        public AirQualityAPI()
        {
            // Store the token we need to use the AirQuality
            apiToken = "454cac0b25995e1a4566c412dab345ddacbea0fa";
        }

        public void GetData()
        {
            var client = new RestClient(api_Url);

            var request = new RestRequest("feed/{city}", Method.GET);
            request.AddParameter("token", apiToken);
            request.AddUrlSegment("city", "Plymouth");

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

    }
}
