using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description, string phone)
    {
      Name = name;
      Description = description;
      Phone = phone;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}