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
int[,] matrix = new int[5, 5];
double sum = 0;
void Count(int[,] matrix)
{
Console.Write("Среднее арифметическое каждого столбца:");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            sum += matrix[j, i];
            if(j + 1 == matrix.GetLength(1)) sum /= j + 1;
        }
        Console.Write($" {sum}");
    } 
}
Console.Clear();
ImputMatrix(matrix);
PrintMatrix(matrix);
Count(matrix);