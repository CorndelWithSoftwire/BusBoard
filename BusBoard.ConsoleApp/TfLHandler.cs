using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
    class TfLHandler
    {
        public void getArrivals(string code)
        {
            var client = new RestClient("https://api.tfl.gov.uk/");
            var request = new RestRequest("StopPoint/"+code+"/Arrivals",Method.GET, DataFormat.Json);
            var reponse = client.Execute(request);
            if(reponse.Content == null)
            {
                throw new Exception("got here");
            }
            Console.WriteLine(reponse.ContentType);
            Console.WriteLine(reponse.Content);
        }
    }
}
