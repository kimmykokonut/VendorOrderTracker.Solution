using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.TestTools
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Scone", "yummy");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Scone";
      Order testOrder = new Order(title, "yummy");
      string result = testOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetsValueOfTitle_String()
    {
      string title = "Scone";
      Order testOrder = new Order(title, "yummy");
      string updatedTitle = "Danish";
      testOrder.Title = updatedTitle;
      string result = testOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsValueOfDescription_String()
    {
      string title = "Scone";
      string description = "A biscuit-like treat full of butter";
      Order testOrder = new Order(title, description);
      string result = testOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}