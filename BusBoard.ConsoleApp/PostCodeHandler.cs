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
            PostCode p =  client.Get<PostCode>(uri).Data;
            List<double> latlong = new List<double>();
            latlong.Add(p.latitude);
            latlong.Add(p.longitude);
            Console.WriteLine("{0}, {1}", p.latitude.ToString(), p.longitude);
            Console.Read();
            return latlong;
        }
    }
}
