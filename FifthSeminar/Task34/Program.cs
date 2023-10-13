// Создать одномерный массив из случайных трехзначных целых чисел и вывести количество четных чисел

Console.WriteLine("Enter Array Size:");
int a = Convert.ToInt32(Console.ReadLine());
int[] b = GenerateArray(a);

Console.WriteLine($"Array: {ArrayToString(b)}, Result: {GetEvenCount(b)}");

int[] GenerateArray(int size)
{
    int[] res = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)    
        res[i] = rnd.Next(100, 999);
    return res;
}

int GetEvenCount(int[] b)
{
    int res = 0;
    for (int  i = 0; i < b.Length; i++)
        if (b[i] % 2 == 0)
            res ++;
    return res;
}

string ArrayToString(int[] b)
{
    string res = "[" + b[0];
    for (int  i = 1; i < b.Length; i++)
        res += (", " + b[i]);
    return res + "]";
}