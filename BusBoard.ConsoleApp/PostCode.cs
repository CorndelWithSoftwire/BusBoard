using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusBoard.ConsoleApp
{
    class PostCode
    {
        

        [JsonProperty("longitude")]
        public double longitude { get; set; }
        [JsonProperty("latitude")]
        public double latitude { get; set; }


    }
}
