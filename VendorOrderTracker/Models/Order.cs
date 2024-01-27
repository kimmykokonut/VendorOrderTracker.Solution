using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public DateTime DateOrder { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }


    public Order(string title, string description, string price)
    {
      Title = title;
      Description = description;
      Price = price;
      DateOrder = DateTime.Now;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}