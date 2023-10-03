// Принять цифру, обозначающую день недели и сообщить является ли она выходным днем

Console.WriteLine("Enter value:");
WeekendCheck(Console.ReadLine());

void WeekendCheck(string input)
{
    int x;
    if (IsDigital(input, out x) && IsAcceptable(x))
        if (x > 5)
            Console.WriteLine("Entered day of week is off day");
        else
            Console.WriteLine("Entered day of week is labor day");
}


bool IsDigital(string input, out int x)
{
    bool res = int.TryParse(input, out x);
    if (!res)
        Console.WriteLine("Entered value is not digital");
    return res;
}

bool IsAcceptable(int input)
{
    bool res = input > 0 && input < 8;
    if (!res)    
        Console.WriteLine("Entered value is not acceptable");
    return res;
}