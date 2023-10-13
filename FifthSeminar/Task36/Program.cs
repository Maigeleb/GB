// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Enter Array Size:");
int a = Convert.ToInt32(Console.ReadLine());
int[] b = GenerateArray(a);

Console.WriteLine($"Array: {ArrayToString(b)}, Result: {GetOrdinalSum(b)}");

int[] GenerateArray(int size)
{
    int[] res = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)    
        res[i] = rnd.Next(-30, 30);
    return res;
}

int GetOrdinalSum(int[] b)
{
    int res = 0;
    for (int  i = 0; i < b.Length; i = i + 2)
        res += b[i];
    return res;
}

string ArrayToString(int[] b)
{
    string res = "[" + b[0];
    for (int  i = 1; i < b.Length; i++)
        res += (", " + b[i]);
    return res + "]";
}