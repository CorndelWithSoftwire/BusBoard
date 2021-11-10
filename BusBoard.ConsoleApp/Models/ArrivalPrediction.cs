using System;

namespace BusBoard.ConsoleApp.Models
{
    public class ArrivalPrediction
    {
        public string VehicleId { get; set; }
        public string StationName { get; set; }
        public string LineId { get; set; }
        public string LineName { get; set; }
        public string PlatformName { get; set; }
        public string DestinationName { get; set; }
        public int TimeToStation { get; set; }  // predicted; given in seconds
        public DateTime ExpectedArrival { get; set; }  // predicted

        public override string ToString()
        {
            return String.Format("Expected {0:t}: Bus {1} to {2}", ExpectedArrival, LineId, DestinationName);
        }
    }
}