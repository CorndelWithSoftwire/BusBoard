using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBoard.Api;

namespace BusBoard.ConsoleApp
{
    class Arrival
    {
        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("vehicleID")]
        public string VehicleID { get; set; }

        [JsonProperty("timeToStation")]
        public string TimeToStation { get; set; }

        [JsonProperty("expectedArrival")]
        public string ExpectedArrival { get; set; }

        [JsonProperty("lineId")]
        public string LineId { get; set; }

    }
}
