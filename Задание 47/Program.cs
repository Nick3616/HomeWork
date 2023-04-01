void ImputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = new Random().Next(0, 11);
    } 
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    } 
}

Console.Clear();
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, x];
ImputMatrix(matrix);
PrintMatrix(matrix);