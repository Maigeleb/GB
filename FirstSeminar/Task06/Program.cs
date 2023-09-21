// Является ли число четным

Console.WriteLine("Enter value:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(EvenNumber(a) ? a + " is even number" : a + " is odd number");

bool EvenNumber(int a) => a % 2 == 0;