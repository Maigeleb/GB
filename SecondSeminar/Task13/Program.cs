// Принять число и вывести третью цифру, если ее нет - сообщить об этом

Console.WriteLine("Enter value:");
GetThirdDigit(Console.ReadLine());

void GetThirdDigit(string input)
{
    if (IsDigital(input) && HasThreeDigit(input))
        Console.WriteLine($"Third digit: {input[2]}");
}

bool IsDigital(string input) 
{
    bool res = int.TryParse(input, out int x);
    if (!res)    
        Console.WriteLine("Entered value is not digital");
    return res;
} 

bool HasThreeDigit(string input)
{
    bool res = input.Length > 2;
    if (!res)
        Console.WriteLine("Entered value has not third digit");
    return res;
}