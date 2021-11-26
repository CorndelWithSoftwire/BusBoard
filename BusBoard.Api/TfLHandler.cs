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

namespace BusBoard.Api
{
    public class TfLHandler
    {
        public List<Arrival>getArrivals(string code)
        {
            var client = new RestClient("https://api.tfl.gov.uk");
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            var uri = new RestRequest("/StopPoint/" + code + "/Arrivals", Method.GET, DataFormat.Json);

            List<Arrival> response = client.Get<List<Arrival>>(uri).Data;

            return response;
        }
        public Dictionary<string, List<Arrival>> getStopsWithinRadius(Dictionary<string,double> location)
        {
            //"StopPoint?radius=500&lat=51.49454&lon=-0.100601&stopTypes=NaptanOnstreetBusCoachStopPair"
            var client = new RestClient("https://api.tfl.gov.uk");
            
            var uri = new RestRequest( string.Format("StopPoint?lat={0}&lon={1}&stopTypes=NaptanPublicBusCoachTram&radius=200&modes=bus", location["latitude"], location["longitude"]), Method.GET, DataFormat.Json);
            StopWrapper stops = client.Get <StopWrapper>(uri).Data;
            
            Dictionary<string, List<Arrival>> dict = new Dictionary<string, List<Arrival>>();
          
            foreach (Stop stop in stops.stopPoints)
            {
                if(dict.ContainsKey(stop.CommonName))
                {
                    continue;
                }
                dict.Add(stop.CommonName, getArrivals(stop.naptanId));
            }

            return dict;
        }
    }
}
