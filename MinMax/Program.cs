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

double min = doubles[0];
double max = doubles[0];

for (int i = 0; i < intNumberOfNumbers; i++)
{
    if (min >= doubles[i])
    {
        min = doubles[i];
    }

    if (max <= doubles[i])
    {
        max = doubles[i];
    }
}

Console.WriteLine($"Minimum value is {min.ToString()} and Maximum value is {max.ToString()}");