
using Approved;

Calculate calculate = new Calculate();

Console.WriteLine("Nome do aluno");
calculate.Name = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno");
calculate.A = double.Parse(Console.ReadLine());
calculate.B = double.Parse(Console.ReadLine());
calculate.C = double.Parse(Console.ReadLine());


Console.WriteLine($"NOTA FINAL = {calculate.CalculateGrade():F2}");
Console.WriteLine($"{calculate.IsApprovedPerson():F2}");


if (calculate.CalculateGrade() < 60)
{
    Console.WriteLine($"FALTARAM {calculate.CalculateNecessairePoints():F2} PONTOS");
}