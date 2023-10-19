// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = EnterValue("M");
int n = EnterValue("N");

Console.WriteLine($"A({m}; {n}) => {Ackerman(m, n)}");

int Ackerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackerman(n - 1, 1);
    }
    else
    {
        return Ackerman(n - 1, Ackerman(n, m - 1));  
    }
}

int EnterValue(string Name)
{
    Console.WriteLine($"Enter Start {Name}:");
    string s = Console.ReadLine();
    int a;
    while (!Int32.TryParse(s, out a))
    {
        Console.WriteLine("Incorrect input");
        Console.WriteLine($"Enter Start {Name}:");
        s = Console.ReadLine();
    }
    return a;
}