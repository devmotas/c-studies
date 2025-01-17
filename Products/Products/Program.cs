

using System.Globalization;
using Products.Entities;

Console.WriteLine("Enter ther number of products");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("");

List<Product> products = new List<Product>();

for (int i = 0; i < n; i++)
{
    Console.Write($"Product #{i + 1} data:");
    Console.WriteLine("");

    Console.Write("Common, used or imported (c/u/i)?");
    char type = char.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("");

    if (type == 'u')
    {
        Console.Write("Manafacture date (DD/MM/YY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("");
        products.Add(new UsedProduct(name, price, date));
    }
    else if (type == 'i')
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("");
        products.Add(new ImportedProduct(name, price, fee));
    }
    else
    {
        products.Add(new Product(name, price));
    }
    }


Console.WriteLine("PRICE TAGS:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}