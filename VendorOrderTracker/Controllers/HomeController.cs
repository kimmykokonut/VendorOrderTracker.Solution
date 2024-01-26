using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers //change name
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    {
      return View();
    }
  }
}