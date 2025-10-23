Console.WriteLine("How many numbers?");
string numberOfNumbers = Console.ReadLine();

if (!int.TryParse(numberOfNumbers, out int intNumberOfNumbers))
{
    Console.WriteLine("Invalid input for number of loops");
    return;
}

double[] doubles = new double[intNumberOfNumbers];
for (int i = 0; i < intNumberOfNumbers; i++)
{
    Console.WriteLine($"Enter the number {i + 1}:");
    string strNumber = Console.ReadLine();
    if (int.TryParse(strNumber, out int doubleNumber))
    {
        doubles[i] = doubleNumber;
    }
    else
    {
        Console.WriteLine($"{strNumber} is not proper number. Do you want to correct it? (Y/N)");
        string respons = Console.ReadLine();
        if (!string.IsNullOrEmpty(respons) && respons == "Y")
        {
            i--;
        }
        else
        {
            intNumberOfNumbers--;
        }
    }
}


Dictionary<double,int> keyValues = new Dictionary<double, int>();
for (int i = 0;i < intNumberOfNumbers;i++)
{
    if (!keyValues.ContainsKey(doubles[i]))
    {
        keyValues.Add(doubles[i], 1);
    }
    else
    {
        keyValues.TryGetValue(doubles[i], out int frequency);
        frequency++;
        keyValues[doubles[i]] = frequency;
    }    
}

foreach (var item in keyValues)
{
    Console.WriteLine($"Number {item.Key} appears {item.Value} times");
}