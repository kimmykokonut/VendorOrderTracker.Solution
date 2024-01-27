using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.TestTools
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void SetPrice_SetsValueOfPrice_Int()
    {
      string title = "Scone";
      string description = "A vegan take on the British classic";
      int price = 5;
      Order testOrder = new Order(title, description, price);
      int updatedPrice = 10;
      testOrder.Price = updatedPrice;
      int result = testOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }
    [TestMethod]
    public void GetDate_ReturnsTimeStampDate_Date()
    {
      string title = "Scone";
      string description = "A vegan take on the British classic";
      int price = 5;
      Order testOrder = new Order(title, description, price);
      DateTime timeStamp = testOrder.DateOrder;
      DateTime result = DateTime.Now;
      Assert.AreEqual(timeStamp.Date, result.Date);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title = "Scone";
      string description = "A biscuit-like treat full of butter";
      int price = 5;
      Order testOrder1 = new Order(title, description, price);
      string title2 = "Bagel";
      string description2 = "Boiled and baked to perfection";
      int price2 = 3;
      Order testOrder2 = new Order(title2, description2, price2);
      List<Order> newList = new List<Order> { testOrder1, testOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrderCreatesWithIdAndGetReturnsOrderId_Int()
    {
      string title = "Scone";
      string description = "A biscuit-like treat full of butter";
      int price = 5;
      Order testOrder = new Order(title, description, price);
      int result = testOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title = "Scone";
      string description = "A biscuit-like treat full of butter";
      int price = 5;
      Order testOrder1 = new Order(title, description, price);
      string title2 = "Bagel";
      string description2 = "Boiled and baked to perfection";
      int price2 = 3;
      Order testOrder2 = new Order(title2, description2, price2);
      Order result = Order.Find(2);
      Assert.AreEqual(testOrder2, result);
    }
  }
}