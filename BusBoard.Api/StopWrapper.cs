using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BusBoard.Api
{
    class StopWrapper
    {
        [JsonProperty("$type")]
        public string type { get; set; }
        [JsonProperty("centrePoint")]
        public List<double> centrePoint { get; set; }
        [JsonProperty("stopPoints")]
        public List<Stop> stopPoints { get; set; }
        

    }
}
