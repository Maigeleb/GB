// Получить максимальное из двух чисел

Console.WriteLine("Enter First value:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second value:");
int b =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max value: " + GetMax2(a, b));

float GetMax2(float a, float b) => a > b ? a : b;