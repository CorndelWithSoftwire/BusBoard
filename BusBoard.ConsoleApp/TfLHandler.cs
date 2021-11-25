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
            foreach(Arrival a in response)
            {
                Console.WriteLine(string.Format("{0,7} || {1,-20} || {2,4} || {3,-20}", a.VehicleID, a.DestinationName, a.TimeToStation, a.ExpectedArrival));
            }
        }
        public void getStopsWithinRadius(Dictionary<string,double> location)
        {
            //"StopPoint?radius=500&lat=51.49454&lon=-0.100601&stopTypes=NaptanOnstreetBusCoachStopPair"
            var client = new RestClient("https://api.tfl.gov.uk");
            
            var uri = new RestRequest( string.Format("/StopPoint?radius=500&lat={0}&lon={1}&stopTypes=NaptanOnstreetBusCoachStopPair", location["latitude"], location["longitude"]), Method.GET, DataFormat.Json);
            StopWrapper stops = client.Get <StopWrapper>(uri).Data;

            Stop stop = stops.stopPoints[0];
            
            getArrivals(stop.naptanId);
            

            Console.ReadLine();
        }
    }
}
