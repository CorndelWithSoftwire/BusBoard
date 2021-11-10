using System;
using System.Linq;
using BusBoard.ConsoleApp.Client;

namespace BusBoard.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var client = new TflClient();
      
      var nextArrivals = client.GetArrivalPredictions(args[0])
        .OrderBy(a => a.TimeToStation)
        .Take(5)
        .ToList();

      Console.Out.WriteLine("Next {0} arrivals at stop {1}:", nextArrivals.Count, args[0]);
      foreach (var arrival in nextArrivals)
      {
        Console.Out.WriteLine(arrival);
      }
    }
  }
}
