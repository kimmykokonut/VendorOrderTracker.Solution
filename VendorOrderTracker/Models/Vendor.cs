namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Phone { get; }
    public Vendor(string name, string description, string phone)
    {
      Name = name;
      Description = description;
      Phone = phone;
    }
  }
}