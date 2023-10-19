// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


int m = EnterValue("M");
int n = EnterValue("N");

if (m > n)
{
    Console.WriteLine($"{m} > {n}:");
    return;
}

Console.WriteLine($"{m}; {n} => {SumNaturalArray(m, n)}");

int SumNaturalArray(int start, int end)
{
    int res = 0;
    while (end >= start)
    {
        res += end;
        end--;
    }
    return res;
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

