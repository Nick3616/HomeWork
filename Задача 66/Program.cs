int f(int n, int m)
{
    int sum = 0;
    if(m > n)
        return 0;
    return m + f(n, m + 1);
}

Console.Clear();
Console.Write("Ввидите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Ввидите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));