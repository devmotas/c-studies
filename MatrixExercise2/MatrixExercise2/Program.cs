

string[] n = Console.ReadLine().Split(' ');

int[,] mat = new int[int.Parse(n[0]), int.Parse(n[1])];


for (int y = 0; y < mat.GetLength(1); y++)
{
    string[] line = Console.ReadLine().Split(' ');
    for (int x = 0; x < mat.GetLength(0); x++)
    {
        mat[x, y] = int.Parse(line[x]);
    }
    Console.WriteLine();

}


int findNumeber = int.Parse(Console.ReadLine());

void PrintItems()
{
    for (int y = 0; y < mat.GetLength(1); y++)
    {
        for (int x = 0; x < mat.GetLength(0); x++)
        {
            if (mat[x, y] == findNumeber)
            {
                Console.WriteLine($"Position {x},{y}");

                if (GetLeft(x, y) != null) Console.WriteLine($"Left: {GetLeft(x, y)}");
                if (GetRight(x, y) != null) Console.WriteLine($"Right: {GetRight(x, y)}");
                if (GetTop(x, y) != null) Console.WriteLine($"Up: {GetTop(x, y)}");
                if (GetBottom(x, y) != null) Console.WriteLine($"Down: {GetBottom(x, y)}");
            };
        }

    }
}
int? GetTop(int x, int y)
{
    if (x - 1 >= 0)
    {
        return mat[x - 1, y];
    }
    return null;
}

int? GetBottom(int x, int y)
{
    if (x + 1 < mat.GetLength(0))
    {
        return mat[x + 1, y];
    }
    return null;
}

int? GetLeft(int x, int y)
{
    if (y - 1 >= 0)
    {
        return mat[x, y - 1];
    }
    return null;
}

int? GetRight(int x, int y)
{
    if (y + 1 < mat.GetLength(1))
    {
        return mat[x, y + 1];
    }
    return null;
}