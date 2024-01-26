using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vId}/orders/new")]
    public ActionResult New(int vId)
    {
      Vendor vendor = Vendor.Find(vId);
      return View(vendor);
    }
  }
}