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
    [HttpGet("/vendors/{vId}/orders/{oId}")]
    public ActionResult Show(int vId, int oId)
    {
      Vendor selectedVendor = Vendor.Find(vId);
      Order selectedOrder = Order.Find(oId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", selectedOrder);
      model.Add("vendor", selectedVendor);
      return View(model);
    }
  }
}