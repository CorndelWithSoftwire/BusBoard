using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.Api
{
    public class Arrival
    {
        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("vehicleID")]
        public string VehicleID { get; set; }

        [JsonProperty("timeToStation")]
        public string TimeToStation { get; set; }

        [JsonProperty("expectedArrival")]
        public string ExpectedArrival { get; set; }

    }
}
