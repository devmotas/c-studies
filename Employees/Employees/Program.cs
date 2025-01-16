

using Employees.Entities;

Console.Write("Enter the number of employees: ");
int n = 3;


Console.WriteLine($"Employee #1 data:");
Console.Write("Outsourced (y/n)? ");
char ch1 = 'n';
Console.Write(ch1);
Console.WriteLine();

Console.Write("Name:");
string name1 = "Alex";
Console.Write(name1);
Console.WriteLine();

Console.Write("Hours:");
int hours1 = 50;
Console.Write(hours1);
Console.WriteLine();

Console.Write("Value per hour:");
double valuePerHour1 = 20.00;
Console.Write(valuePerHour1);
Console.WriteLine();

Console.WriteLine($"Employee #2 data:");
Console.Write("Outsourced (y/n)? ");
char ch2 = 'y';
Console.Write(ch2);
Console.WriteLine();

Console.Write("Name:");
string name2 = "Bob";
Console.Write(name2);
Console.WriteLine();

Console.Write("Hours:");
int hours2 = 100;
Console.Write(hours2);
Console.WriteLine();
Console.Write("Value per hour:");
double valuePerHour2 = 15.00;
Console.Write(valuePerHour2);
Console.WriteLine();

Console.Write("Additional charge:");
double additionalCharge2 = 200.00;
Console.Write(additionalCharge2);
Console.WriteLine();

Console.WriteLine($"Employee #3 data:");
Console.Write("Outsourced (y/n)? ");
char ch3 = 'n';
Console.Write(ch3);
Console.WriteLine();

Console.Write("Name:");
string name3 = "Maria";
Console.Write(name3);
Console.WriteLine();

Console.Write("Hours:");
int hours3 = 60;
Console.Write(hours3);
Console.WriteLine();

Console.Write("Value per hour:");
double valuePerHour3 = 20.00;
Console.Write(valuePerHour3);
Console.WriteLine();

Employee emp1 = new Employee(name1, hours1, valuePerHour1);
Employee emp2 = new OutsorcedEmployee(name2, hours2, valuePerHour2, additionalCharge2);
Employee emp3 = new Employee(name3, hours3, valuePerHour3);


Console.WriteLine("PAYMENTS:");
Console.WriteLine(emp1);
Console.WriteLine(emp2);
Console.WriteLine(emp3);


