using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vName, string vDescription, string vPhone)
    {
      Vendor newVendor = new Vendor(vName, vDescription, vPhone);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{vId}")]
    public ActionResult Show(int vId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vId);
      //add orders list later once orders created
      model.Add("vendor", selectedVendor);
      return View(model);
    }
  }
}