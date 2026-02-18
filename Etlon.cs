namespace Etlon;

public enum DrinkSize { Small, Medium, Large }

public class DrinkSizePricing
{
  public static decimal GetExtraCost(DrinkSize sz)
  {
    return sz switch
    {
      DrinkSize.Small => 0m,
      DrinkSize.Medium => 0.5m,
      DrinkSize.Large => 1m,
      _ => 0m,
    };
  }
}

public class Option
{
  required public string Name { get; set; }
  required public decimal Cost { get; set; }
}

public class Drink
{
  required public string Name { get; set; }
  required public decimal Cost { get; set; }

  private readonly List<Option> Options = [];

  public void AddOption(Option o)
  {
    Options.Add(o);
  }

  public decimal GetTotal()
  {
    decimal ans = Cost;
    foreach (var o in Options)
    {
      if (o != null)
      {
        ans += o.Cost;
      }
    }
    return ans;
  }
}

public class OrderItem(Drink drink, DrinkSize size)
{
  public Drink Drink { get; set; } = drink;
  public DrinkSize Size { get; set; } = size;

  public decimal GetTotal()
  {
    return DrinkSizePricing.GetExtraCost(Size) + Drink.GetTotal();
  }
}

public class Order
{
  public List<OrderItem> Items { get; private set; } = [];

  public void AddItem(OrderItem item)
  {
    Items.Append(item);
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

