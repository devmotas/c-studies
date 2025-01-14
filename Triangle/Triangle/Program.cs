
using Triangle;

Calculate retangle =  new Calculate();

Console.WriteLine("Entre a largura e altura do retangulo");

retangle.width = double.Parse(Console.ReadLine());
retangle.height = double.Parse(Console.ReadLine());

Console.WriteLine($"Area = {retangle.CalculateArea():F2}");
Console.WriteLine($"Perimetro = {retangle.CalculatePerimeter():F2}");
Console.WriteLine($"Diagonal = {retangle.CalculateDiagonal():F2}");
