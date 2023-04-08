string f(int n)
{
    if(n == 0)
        return "";
    return $"{n} " + f(n - 1);
}

Console.Clear();
Console.Write("Ввидите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));