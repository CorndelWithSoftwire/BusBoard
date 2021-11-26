using System.Text.RegularExpressions;
using System.Web.Mvc;
using BusBoard.Web.Models;
using BusBoard.Web.ViewModels;
using BusBoard.Api;
namespace BusBoard.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public ActionResult BusInfo(PostcodeSelection selection)
    {
            // Add some properties to the BusInfo view model with the data you want to render on the page.
            // Write code here to populate the view model with info from the APIs.
            // Then modify the view (in Views/Home/BusInfo.cshtml) to render upcoming buses.
            var info = new BusInfo(selection.Postcode);
        Regex regex = new Regex(@"([Gg][Ii][Rr] 0[Aa]{ 2 })| ((([A - Za - z][0 - 9]{ 1,2})| (([A - Za - z][A - Ha - hJ - Yj - y][0 - 9]{ 1,2})| (([A - Za - z][0 - 9][A - Za - z]) | ([A - Za - z][A - Ha - hJ - Yj - y][0 - 9][A - Za - z] ?))))\s?[0 - 9][A - Za - z]{ 2})");
        if(regex.IsMatch(selection.Postcode))
        {
                ViewBag.Message = "these are your busses";
        }
        
      return View(info);
    }

    public ActionResult About()
    {
      ViewBag.Message = "It is a website for bus times in the radius of your loaction";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Contact us!";

      return View();
    }
  }
}