using BusBoard.Api;

namespace BusBoard.Web.ViewModels
{
  public class BusInfo
  {
    public BusInfo(string postCode)
    {
      PostCode = postCode;
            TfLHandler t = new TfLHandler();
            PostCodeHandler p = new PostCodeHandler();
            t.getStopsWithinRadius(p.GetLatLong(postCode));
    }

    public string PostCode { get; set; }
    
    
  }
}