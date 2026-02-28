namespace Etlon.Order;

public class Order
{
  public List<OrderItem> Items { get; private set; } = [];

  public void AddItem(OrderItem item)
  {
    Items.Add(item);
  }

  public decimal GetSubtotal()
  {
    decimal ans = 0;
    foreach (var it in Items)
    {
      ans += it.GetTotal();
    }
    return ans;
  }
}
