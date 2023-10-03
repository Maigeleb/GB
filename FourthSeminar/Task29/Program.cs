// Принять массив чисел размером до 8 элементов и составить из него массив из 8 элементов, недостающие элементы заполнить случайными числами 

GenerateArray();

void GenerateArray()
{
    string[] inputArray; 
    int[] a;
    Console.WriteLine("Enter Array:");
    
    if (AcceptableSize(Console.ReadLine(), out inputArray) && AreDigital(inputArray))
    {
        a = SetArray(inputArray);

        int[] res = ExpandedArray(a);
        
        Console.WriteLine($"Result: {GetArray(a)} -> [{GetArray(res)}]");
    }

}

string GetArray(int[] input)
{
    string res = "";
    for (int i = 0; i < input.Length; i++)
        res = (i != (input.Length - 1)) ? res + input[i] + ", " : res + input[i];
    return res;
}

int[] ExpandedArray(int[] input)
{
    int[] res = new int[8];
    Random random = new Random();

    for (int i = 0; i < res.Length; i++)
        res[i] = input.Length <= i ? random.Next(0, 10) : input[i];
    return res;
}

bool AreDigital(string[] input) 
{
    for (int i = 0; i < input.Length; i++)
        if (!IsDigital(input[i]))
            return false;
    return true;
} 

bool IsDigital(string input) 
{
    bool res = int.TryParse(input, out int x);
    if (!res)    
        Console.WriteLine("Entered value is not digital");
    return res;
} 

bool AcceptableSize(string s, out string[] splits)
{
    splits = s.Split(',');
    bool res = splits.Length <= 8;
    if (!res)
        Console.WriteLine("Entered Array is too long");
    return res;
}

int[] SetArray(string[] splits)
{
    int[] res = new int[splits.Length];
    for (int i = 0; i < splits.Length; i++)
    {
        res[i] = Convert.ToInt32(splits[i]);
    }
    return res;
}