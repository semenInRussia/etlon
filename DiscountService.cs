namespace Etlon;

public class DiscountService
{
  public decimal CalculateTotalDiscount(Order order)
  {
    if (order.Items.Count > 3)
    {
      return order.GetSubtotal() * 0.1m;
    }
    return 0;
  }
}
