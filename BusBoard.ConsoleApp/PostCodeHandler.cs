using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
    class PostCodeHandler
    {
         public List<double> GetLatLong(string postcode)
        {
            var client = new RestClient("https://api.postcodes.io");
            var uri = new RestRequest("/postcodes/" + postcode , Method.GET, DataFormat.Json);
            PostcodeWrapper p =  client.Get<PostcodeWrapper>(uri).Data;
            List<double> latlong = new List<double>();
            latlong.Add(p.result.Latitude);
            latlong.Add(p.result.Longitude);
            Console.WriteLine("{0}, {1}", p.result.Latitude, p.result.Longitude);
            Console.Read();
            return latlong;
        }
    }
}
