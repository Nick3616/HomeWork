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
void Search(int[] size)
{
    if(matrix.GetLength(0) < size[0] && matrix.GetLength(1) < size[1])
    Console.Write("Такой позиции нет");
    else 
    Console.Write($"{matrix[size[0] - 1, size[1] - 1]}");
}
Console.Clear();
Console.Write("Введите позиции элемента: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

ImputMatrix(matrix);
PrintMatrix(matrix);
Search(size);