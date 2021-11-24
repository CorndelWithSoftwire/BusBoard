using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;

namespace BusBoard.ConsoleApp
{
    class TfLHandler
    {
        public void getArrivals(string code)
        {
            var client = new RestClient("https://api.tfl.gov.uk");
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            var uri = new RestRequest("/StopPoint/" + code + "/Arrivals", Method.GET, DataFormat.Json);

            List<Arrival> response = client.Get<List<Arrival>>(uri).Data;
            for(int i = 0; i <5; i++)
            {
                Arrival a = response[i];
                Console.WriteLine(string.Format("{0,7} || {1,-20} || {2,4} || {3,-20}", a.VehicleID, a.DestinationName, a.TimeToStation, a.ExpectedArrival));
            }
            Console.ReadLine();

            

        }
    }
}
