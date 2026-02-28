namespace Etlon.Order;

using Etlon.Drink;

public class OrderItem(Drink drink, DrinkSize size)
{
  public Drink Drink { get; set; } = drink;
  public DrinkSize Size { get; set; } = size;

  public decimal GetTotal()
  {
    return DrinkSizePricing.GetExtraCost(Size) + Drink.GetTotal();
  }
}
