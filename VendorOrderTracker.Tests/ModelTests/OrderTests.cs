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
      Order newOrder = new Order("Scone", "yummy", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Scone";
      Order testOrder = new Order(title, "yummy", 5);
      string result = testOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetsValueOfTitle_String()
    {
      string title = "Scone";
      Order testOrder = new Order(title, "yummy", 5);
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
      Order testOrder = new Order(title, description, 5);
      string result = testOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetsValueOfDescription_String()
    {
      string title = "Scone";
      string description = "A vegan take on the British classic";
      Order testOrder = new Order(title, description, 5);
      string updatedDescription = "You won't miss the dairy in this treat";
      testOrder.Description = updatedDescription;
      string result = testOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsValueOfPrice_Int()
    {
      string title = "Scone";
      string description = "A biscuit-like treat full of butter";
      int price = 5;
      Order testOrder = new Order(title, description, price);
      int result = testOrder.Price;
      Assert.AreEqual(price, result);
    }




  }
}