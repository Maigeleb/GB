// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Enter numbers:");
string s = Console.ReadLine();
int[] elements;
if (CheckInput(s, out elements))
{
    Console.WriteLine($"{s} => {MoreThanZeroCount(elements)}");
}
else
{
    Console.WriteLine("Incorrect input!");
}

bool CheckInput(string s, out int[] elements)
{
    string[] stringElements = s.Split(',');
    elements = new int[stringElements.Length];

    for (int i = 0; i < elements.Length; i++)
        if (!Int32.TryParse(stringElements[i], out elements[i]))
            return false;
    return true;
}

string MoreThanZeroCount(int[] elements)
{
    int res = 0;

    for (int i = 0; i < elements.Length; i++)
        if (elements[i] > 0)
            res++;
    return res.ToString();
}
