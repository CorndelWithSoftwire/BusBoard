using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using BusBoard.ConsoleApp.Models;
using RestSharp;

namespace BusBoard.ConsoleApp
{
  class Program
  {
    private const string AppKey = "4a212c35b632ba9d2f43c5e1fcb7c3e6";
    
    static void Main(string[] args)
    {
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      
      var client = new RestClient("https://api.tfl.gov.uk");

      var request = new RestRequest(
        String.Format("StopPoint/490008660N/Arrivals?app_key={0}", AppKey)
      );

      var response = client.Get<List<ArrivalPrediction>>(request);

      var nextArrivals = response.Data
        .OrderBy(a => a.TimeToStation)
        .Take(5)
        .ToList();

      Console.Out.WriteLine("Next {0} arrivals:", nextArrivals.Count());
      foreach (var arrival in nextArrivals)
      {
        Console.Out.WriteLine(arrival);
      }
    }
  }
}
