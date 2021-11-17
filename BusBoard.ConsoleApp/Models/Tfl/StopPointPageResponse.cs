using System.Collections.Generic;

namespace BusBoard.ConsoleApp.Models.Tfl
{
    public class StopPointPageResponse
    {
        public List<StopPoint> StopPoints { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
    }
}