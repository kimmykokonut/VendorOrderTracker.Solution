namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; }

    public Order(string title)
    {
      Title = title;
    }
  }
}