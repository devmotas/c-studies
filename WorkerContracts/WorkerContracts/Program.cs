
using System.Globalization;
using WorkerContracts.Entities;
using WorkerContracts.Entities.Enums;

Console.Write("Enter deparment's name:");
string department = Console.ReadLine();
Console.WriteLine();


Console.WriteLine("Enter worker data:");

Console.Write("Name:");
string name = Console.ReadLine();
Console.WriteLine();

Console.Write("Level (Junior/MidLevel/Senior):");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.WriteLine();

Console.Write("Base salary:");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.Write("How many contracts to this worker?:");
int contractsQuantity = int.Parse(Console.ReadLine());
Console.WriteLine();

Worker worker = new Worker
{
    Name = name,
    BaseSalary = baseSalary,
    Level = level,
    Department = new Department(department)
};


for (int i = 0; i < contractsQuantity; i++)
{
    Console.WriteLine($"Enter #{i + 1} contract data:");

    Console.Write("Date (DD/MM/YYYY):");
    DateTime contractDate = DateTime.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Value per hour:");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    Console.Write("Duration (hours):");
    int duration = int.Parse(Console.ReadLine());
    Console.WriteLine();

    worker.AddContract(new HourContract
    {
        Date = contractDate,
        ValuePerHour = valuePerHour,
        Hour = duration
    });
}

Console.Write("Enter month and year to calculate income (MM/YYYY):");
string date = Console.ReadLine();
int year = int.Parse(date.Split('/')[1]);
int month = int.Parse(date.Split('/')[0]);

Console.WriteLine();

double workIncome = worker.Income(year, month);
Console.WriteLine($"Name {worker.Name}");
Console.WriteLine($"Department {worker.Department}");
Console.WriteLine($"Income {workIncome}");














