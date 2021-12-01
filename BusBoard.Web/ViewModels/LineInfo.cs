using BusBoard.Api;
using System;
using System.Collections.Generic;

namespace BusBoard.Web.ViewModels
{
    public class LineInfo
    {
        public LineInfo(string lineID)
        {
            
            TfLHandler t = new TfLHandler();
            Stops = t.GetStopsOnLine(lineID);
            LineID = lineID;
        }

        public string LineID { get; set; }

        public List<Stop> Stops{ get; set; }

    }
}