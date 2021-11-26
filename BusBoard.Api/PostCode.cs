using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusBoard.Api
{
    class PostCode
    {
        
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("postcode")]
        public string Postcode { get; set; }

    }
}
