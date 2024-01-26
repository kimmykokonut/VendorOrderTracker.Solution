using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.TestTools
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sweetpeas", "Vegan bakery", "5551234567");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Little T";
      Vendor newVendor = new Vendor(name, "a place", "123");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetsValueOfName_String()
    {
      string name = "Little T";
      Vendor newVendor = new Vendor(name, "a place", "123");
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
      string phone = "5551231234";
      Vendor newVendor = new Vendor(name, description, phone);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetsValueOfDescription_String()
    {
      string name = "Little T";
      string description = "A neighborhood bakery specializing in locally sourced ingredients";
      string phone = "5551231234";
      Vendor newVendor = new Vendor(name, description, phone);
      string updatedDescription = "A bakery that only sells ciabatta";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetPhone_ReturnsPhone_String()
    {
      string name = "Little T";
      string description = "A neighborhood bakery specializing in locally sourced ingredients";
      string phone = "5551231234";
      Vendor newVendor = new Vendor(name, description, phone);
      string result = newVendor.Phone;
      Assert.AreEqual(phone, result);
    }
    [TestMethod]
    public void SetPhone_SetsValueOfPhone_String()
    {
      string name = "Little T";
      string description = "A neighborhood bakery specializing in locally sourced ingredients";
      string phone = "5551231234";
      Vendor newVendor = new Vendor(name, description, phone);
      string updatedPhone = "A bakery that only sells ciabatta";
      newVendor.Phone = updatedPhone;
      string result = newVendor.Phone;
      Assert.AreEqual(updatedPhone, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }


  }
}