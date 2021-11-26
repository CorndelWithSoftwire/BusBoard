using BusBoard.Api;
using System;
using System.Collections.Generic;

namespace BusBoard.Web.ViewModels
{
  public class BusInfo
  {
    public BusInfo(string postCode)
    {
      PostCode = postCode;
            TfLHandler t = new TfLHandler();
            PostCodeHandler p = new PostCodeHandler();
            try
            {
                Stops = t.getStopsWithinRadius(p.GetLatLong(postCode));
            }
            catch (Exception)
            {
                throw;
            }

    }

    public string PostCode { get; set; }
    public Dictionary<string, List<Arrival>> Stops { get; set; }

    }
}