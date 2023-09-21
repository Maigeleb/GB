// Получить максимальное из трех чисел

Console.WriteLine("Enter First value:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second value:");
int b =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Third value:");
int c =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max value: " + GetMax3(a, b, c));

float GetMax2(float a, float b) => a > b ? a : b;

float GetMax3(float a, float b, float c)
{
	float x = GetMax2(a, b);
	float y = GetMax2(b, c);
	return GetMax2(x, y);
}