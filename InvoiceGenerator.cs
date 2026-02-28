namespace Etlon;

public class InvoiceGenerator
{
  public string GenerateInvoice(Order order, decimal finalPrice, decimal discount)
  {
    StringBuilder sb = new();
    foreach (var item in order.Items)
    {
      sb.AppendLine($"{item.Drink.GetDescription()} [{item.GetTotal()}]");
    }
    sb.AppendLine("---");
    sb.AppendLine($"Subtotal: {order.GetSubtotal()}");
    sb.AppendLine($"Discount: {discount}");
    sb.AppendLine($"Total: {finalPrice}");
    return sb.ToString();
  }
}
