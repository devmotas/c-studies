

using System.Globalization;
using IncreasePayment;

Console.Write("How many people will be registered?");
int quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

List<Payment> paymentList = new List<Payment>();

for (int i = 0; i < quantity; i++)
{
    Console.WriteLine($"Employee #{i + 1}");

    Console.Write("Id:");
    int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Name:");
    string name = Console.ReadLine();

    Console.Write("Salary:");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    paymentList.Add( new Payment { Id = id, Name = name, Salary = salary });

    Console.WriteLine("");

}

Console.Write("Enter the employee id that will have salary increase:");
int increaseId = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Payment item = paymentList.Find(x => x.Id == increaseId);

if (item != null)
{
    Console.Write("Enter the percentage:");
    double increasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double newSalary = item.Salary + (item.Salary * increasePercentage / 100.00);
    paymentList[paymentList.FindIndex(x => x.Id == increaseId)].Salary = newSalary;
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine("");

Console.WriteLine("Updated list of employees:");
foreach (var x in paymentList)
{
    Console.WriteLine(x.ToString());
}