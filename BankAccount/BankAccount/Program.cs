



using System;
using System.Globalization;
using BankAccount;

Console.WriteLine("Entre o número da conta:");
int Id = int.Parse(Console.ReadLine());

Console.WriteLine("Entre o titular da conta:");
string Name = Console.ReadLine();

Console.WriteLine("Haverá depósito inicial (s/n)?");
char IsInsertingValue = char.Parse( Console.ReadLine().ToLower());

double Amount = 0.0;
if (IsInsertingValue == 's')
{
    Console.WriteLine("Entre o valor do depósito inicial:");
    Amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}

Account account = new Account(Id, Name, Amount);

Console.WriteLine("Dados da conta:");
Console.WriteLine(account.ToString());


Console.WriteLine("Entre um valor para depósito:");
account.AddMoney(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(account.ToString());

Console.WriteLine("Entre um valor para saque:");
account.RmMoney(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(account.ToString());
