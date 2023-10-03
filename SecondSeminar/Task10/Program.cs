// Принять трехзначное число и вывести вторую цифру

Console.WriteLine("Enter value:");
GetSecondDigitofThreeDigitalValue(Console.ReadLine());

void GetSecondDigitofThreeDigitalValue(string input)
{
    if (IsDigital(input) && IsThreeFigures(input))
        Console.WriteLine($"Second digit: {input[1]}");
}

bool IsDigital(string input)
{
    bool res = int.TryParse(input, out int x);
    if (!res)
        Console.WriteLine("Entered value is not digital");
    return res;
} 

bool IsThreeFigures(string input)
{
    bool res = input.Length == 3;
    if (!res)        
        Console.WriteLine("Entered value is not three digital");
    return res;
}