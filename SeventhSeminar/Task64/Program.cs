// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
Console.WriteLine("Enter Start Number:");
string s = Console.ReadLine();
int a = 0;
while (!Int32.TryParse(s, out a))
{
    Console.WriteLine("Incorrect input");
    Console.WriteLine("Enter Start Number:");
    s = Console.ReadLine();
}
s = NaturalArray(a);
Console.WriteLine(a.ToString() + " => " + s);

string NaturalArray(int Num)
{
    string res = Num.ToString();
    Num--;
    while (Num > 0)
    {
        res += ", " + Num;
        Num--;
    }
    return res;
}