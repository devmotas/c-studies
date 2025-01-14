

using System.Globalization;
using Orders.Entities;
using Orders.Entities.Enums;

Console.WriteLine("Enter client data:");

Console.Write("Name:");
string name  = Console.ReadLine();
Console.WriteLine("");

Console.Write("Email:");
string email = Console.ReadLine();
Console.WriteLine("");


Console.Write("Birth date: (DD/MM/YYYY):");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Order data:");

Console.Write("Status:");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.WriteLine("");

Console.Write("How many items for this order?");
int itemsQuantity = int.Parse(Console.ReadLine());
Console.WriteLine("");

Order order = new Order(DateTime.Now, status);
order.Client = new Client(name, email, birthDate);

for (int i = 0; i < itemsQuantity; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data:");

    Console.Write("Product Name:");
    string productName = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Product Price:");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("");

    Console.Write("Quantity:");
    int quantity = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    order.AddItem(new OrderItem(quantity, productPrice, new Product(productName, productPrice)));

}

Console.WriteLine(order.ToString());