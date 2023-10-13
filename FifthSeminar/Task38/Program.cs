// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Enter Array Size:");
int a = Convert.ToInt32(Console.ReadLine());
double[] b = GenerateArray(a);

Console.WriteLine($"Array: {ArrayToString(b)}, Result: {GetMinMaxDiff(b).ToString("F2")}");

double[] GenerateArray(int size)
{
    double[] res = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)    
        res[i] = GetRandomNumber(-100, 100);
    return res;
}

double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

double GetMinMaxDiff(double[] b)
{
    double min = b[0] > b[1] ? b[1] : b[0];
    double max = b[0] > b[1] ? b[0] : b[1];

    for (int  i = 2; i < b.Length; i++)
        if (b[i] > max)
           max = b[i];
        else if (b[i] < min)
            min = b[i];
    return (max - min);
}

string ArrayToString(double[] b)
{
    string res = "[" + b[0].ToString("F2");
    for (int  i = 1; i < b.Length; i++)
        res += (", " + b[i].ToString("F2"));
    return res + "]";
}