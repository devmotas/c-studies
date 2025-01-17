



using System.Globalization;
using ExerciseAbstractMethod.Entities;

Console.Write("Enter the number of tax payers: ");

int n = int.Parse(Console.ReadLine());
Console.WriteLine(n);

List<Person> list = new List<Person>();

for (int i = 0; i < n; i++)
{

    Console.WriteLine($"Tax payer #{i + 1} data:");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new IndividualPerson(name, annualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        list.Add(new CorporatePerson(name, annualIncome, employees));
    }
    Console.WriteLine("");
}

Console.WriteLine("");

Console.WriteLine("TAXES PAID:");
double sum = 0.0;
foreach (Person person in list)
{
    Console.WriteLine(person);
    sum += person.TotalTax();
}

Console.WriteLine("");
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));