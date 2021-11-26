using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.Api
{
    class PostCodeHandler
    {
         public Dictionary<string, double> GetLatLong(string postcode)
        {
            Dictionary<string, double> location = new Dictionary<string, double>();
            var client = new RestClient("https://api.postcodes.io");
            var uri = new RestRequest("/postcodes/" + postcode , Method.GET, DataFormat.Json);
            PostCode p =  client.Get<PostcodeWrapper>(uri).Data.result;
            location.Add("latitude", p.Latitude);
            location.Add("longitude", p.Longitude);
            return location;
        }
    }
}
