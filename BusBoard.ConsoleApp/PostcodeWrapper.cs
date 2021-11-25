using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
    class PostcodeWrapper
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("result")]
        public PostCode result { get; set; }
    }
}
