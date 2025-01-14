

using Employee;

Calculate calculate = new Calculate();



Console.WriteLine("Nome");
calculate.Name = Console.ReadLine();

Console.WriteLine("Salário bruto");
calculate.GrossSalary = double.Parse(Console.ReadLine());


Console.WriteLine("Imposto");
calculate.Tax = double.Parse(Console.ReadLine());


Console.WriteLine($"Funcionário {calculate}");

Console.WriteLine("Digite a porcentagem para aumentar o salário");
calculate.IncreasePayment(double.Parse(Console.ReadLine()));


Console.WriteLine($"Dados atualizados {calculate}");
