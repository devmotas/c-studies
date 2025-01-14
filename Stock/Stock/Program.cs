

using Stock;

Product product = new Product();

Console.WriteLine("Entre os dados do produto");

Console.WriteLine("Nome");
product.name = Console.ReadLine();

Console.WriteLine("Preço");
product.price = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade no estoque");
product.quantity = int.Parse(Console.ReadLine());

Console.WriteLine(product.CreateProduct());

Console.WriteLine("Digite o numero de produtos a serem adicionados no estoque");
product.AddStockProducts(int.Parse(Console.ReadLine()));
Console.WriteLine(product.GetStock());

Console.WriteLine("Digite o numero de produtos a serem removidos do estoque");
product.RmStockProducts(int.Parse(Console.ReadLine()));
Console.WriteLine(product.GetStock());