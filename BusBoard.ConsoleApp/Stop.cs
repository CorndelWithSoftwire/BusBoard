using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
    class Stop
    {
        [JsonProperty("commonName")]
        public string CommonName { get; set; }
        [JsonProperty("naptanId")]
        public string naptanId { get; set; }
    }
}
