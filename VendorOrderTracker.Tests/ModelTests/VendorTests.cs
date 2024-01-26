using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.TestTools
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sweetpeas", "Vegan bakery");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Little T";
      Vendor newVendor = new Vendor(name, "a place");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetsValueOfName_String()
    {
      string name = "Little T";
      Vendor newVendor = new Vendor(name, "a place");
      string updatedName = "Petite Provence";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Little T";
      string description = "A neighborhood bakery specializing in locally sourced ingredients";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetsValueOfDescription_String()
    {
      string name = "Little T";
      string description = "A neighborhood bakery specializing in locally sourced ingredients";
      Vendor newVendor = new Vendor(name, description);
      string updatedDescription = "A bakery that only sells ciabatta";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updatedDescription, result);
    }


  }
}