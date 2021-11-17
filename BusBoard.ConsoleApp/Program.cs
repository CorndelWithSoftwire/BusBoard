using System;
using System.Linq;
using BusBoard.ConsoleApp.Client;

namespace BusBoard.ConsoleApp
00)
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
