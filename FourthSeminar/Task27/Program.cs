// Принять целое число и вывести сумму из составляющих цифр

Console.WriteLine("Enter First Value:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Result: {DecimSum(a)}");

int DecimSum(int a)
{
    string sNumber = a.ToString();
    int res = 0;
    for(int  i = 0; i < sNumber.Length; i++)
    {
        res += (int)Char.GetNumericValue(sNumber[i]);
    }
    return res;
}