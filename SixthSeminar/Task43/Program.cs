// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double b1 = GetValue("b1");
double k1 = GetValue("k1");
double b2 = GetValue("b2");
double k2 = GetValue("k2");

CalculateConnectionPoint(b1, k1, b2, k2);

double GetValue(string name)
{
    Console.WriteLine($"Enter {name}:");
    double value;
    while (!Double.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Incorrect Input!");
        Console.WriteLine($"Enter {name}:");
    }
    return value;
}

void CalculateConnectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            Console.WriteLine("Lines are equal");
        else
            Console.WriteLine("Lines are parallel");
        return;
    }

    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;

    Console.WriteLine($"Connection Point: [{x},{y}]");
}