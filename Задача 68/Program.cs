    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

Console.Clear();
Console.Write("Ввидите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Ввидите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Ackermann(m, n));