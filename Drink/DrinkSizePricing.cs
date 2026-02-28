namespace Etlon.Drink;

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
