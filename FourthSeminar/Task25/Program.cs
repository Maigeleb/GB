// Принять два целых числа и вывести число равное первому, возведенное в степень второго

Console.WriteLine("Enter First Value:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Value:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result: {Step(a, b)}");

int Step(int a, int b)
{
    int i = 1;
    int res = a;
    while(i < b)
    {
        res *= a;
        i++;
    }
    return res;
}