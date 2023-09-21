// Вывести массив всех четных чисел от 2 до введенного

Console.WriteLine("Enter value:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a + " => " + EvenIntegerArray(a));

string EvenIntegerArray(int a)
{
	string result = "";

	if (a < 2)
		return result;
	
    result = "2";

	float size = a % 2 == 0
		? a / 2
		: (a - 1) / 2;
		
	for (int i = 2; i <= size; i++)
	{
        result += ", " + i * 2;
	}
	return result;
}