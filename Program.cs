using Etlon;

Order order = new();

// Заказываем Coffee с опциями и размером Large
Drink coffee = new() { Name = "Coffee", Cost = 2.00m };
coffee.AddOption(new Option { Name = "Milk", Cost = 0.50m });
coffee.AddOption(new Option { Name = "Sugar", Cost = 0.20m });
order.AddItem(new OrderItem(coffee, DrinkSize.Large));

// Заказываем Tea с опцией и размером Small
Drink tea = new() { Name = "Tea", Cost = 1.50m };
tea.AddOption(new Option { Name = "Lemon", Cost = 0.30m });
order.AddItem(new OrderItem(tea, DrinkSize.Small));

// Допустим, добавим ещё пару напитков для проверки скидки:
order.AddItem(new OrderItem(new Drink { Name = "Coffee", Cost = 2.00m }, DrinkSize.Medium));
order.AddItem(new OrderItem(new Drink { Name = "Tea", Cost = 1.50m }, DrinkSize.Medium));

decimal subtotal = order.GetSubtotal();
var discountService = new DiscountService();
decimal discount = discountService.CalculateTotalDiscount(order);
decimal finalPrice = subtotal - discount;

Console.WriteLine("Subtotal: " + subtotal);
Console.WriteLine("Discount: " + discount);
Console.WriteLine("Final Price: " + finalPrice);
Console.ReadLine();

