namespace Etlon;

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

  public string GetDescription()
  {
    string desc = Name;
    if (Options.Count > 0)
    {
      desc += " with " + string.Join(", ", Options.Select(o => o.Name));
    }
    return desc;
  }
}
