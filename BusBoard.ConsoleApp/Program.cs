using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
  class Program
  {
        
    static void Main(string[] args)
    {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //fiveBus(UserInput.GetInput("Please enter a bus stop code:"));
            //Console.Read();
            PostCodeHandler p = new PostCodeHandler();
            p.GetLatLong("NG7 2FB");
    }
    public static void fiveBus(string code)
    {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //https://api.tfl.gov.uk/StopPoint/490008660N/Arrivals
            
            List<string> stops = new List<string>();  //get input from api
            /*for(int i = 0;i < 5;i++)
            {
                string stop = stops[i];
                Console.WriteLine(stop);
            }
            */

            TfLHandler t = new TfLHandler();
            t.getArrivals(code);
            Console.ReadLine();
    }
  }
}
