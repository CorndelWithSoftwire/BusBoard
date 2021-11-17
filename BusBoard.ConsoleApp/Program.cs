using System;
using System.Linq;
using BusBoard.ConsoleApp.Client;

namespace BusBoard.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var tflClient = new TflClient();
      var postcodeClient = new PostcodeClient();

      switch (args[0])
      {
        case "--stop-code":
          var nextArrivals = tflClient.GetArrivalPredictions(args[1])
            .OrderBy(a => a.TimeToStation)
            .Take(5)
            .ToList();

          Console.Out.WriteLine("Next {0} arrivals at stop {1}:", nextArrivals.Count, args[1]);
          foreach (var arrival in nextArrivals)
          {
            Console.Out.WriteLine(arrival);
          }
          break;
        case "--postcode":
          var postcodeData = postcodeClient.GetPostcodeData(args[1]);
          var stopPoints = tflClient
            .GetBusStopPointsWithin(postcodeData.Latitude, postcodeData.Longitude, 500)
            .OrderBy(sp => sp.Distance)
            .Take(2)
            .ToList();
          foreach (var stopPoint in stopPoints)
          {
            var next = tflClient.GetArrivalPredictions(stopPoint.NaptanId)
              .OrderBy(a => a.TimeToStation)
              .Take(5)
              .ToList();
            Console.Out.WriteLine(
              "Next {0} arrivals at stop {1} ({2}):",
              next.Count,
              stopPoint.NaptanId,
              stopPoint.CommonName
            );
            foreach (var arrival in next)
            {
              Console.Out.WriteLine(arrival);
            }
          }
          break;
      }
      
      
    }
  }
}
