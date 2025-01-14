

int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];


for (int y = 0; y < mat.GetLength(1); y++)
{
    string[] line = Console.ReadLine().Split(' ');
    for (int x = 0; x < mat.GetLength(0); x++)
    {
        mat[x, y] = int.Parse(line[x]);
    }
    Console.WriteLine();

}


Console.Write("Main diagonal: ");
for (int x = 0; x < n; x++)
{
    Console.Write($"{mat[x, x]} ");
}

Console.WriteLine();

int negativeNumbers = 0;
for (int y = 0; y < mat.GetLength(1); y++)
{
    for (int x = 0; x < mat.GetLength(0); x++)
    {
        if (mat[x, y] < 0) negativeNumbers++;
    }

}

Console.WriteLine($"Negative numbers = {negativeNumbers}");