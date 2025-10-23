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


//Dictionary<double, int> keyValues = new Dictionary<double, int>();
double[] freq = new double[intNumberOfNumbers];
for (int i = 0; i < intNumberOfNumbers; i++)
{
    freq[i] = -1;
}

for (int i = 0; i < intNumberOfNumbers; i++)
{
    if (freq[i] != -1)
        continue; // already counted
    int counter = 1;
    for (int j = i+1; j < intNumberOfNumbers; j++)
    {
        if(doubles[i] == doubles[j])
        {
            counter++;
            freq[j] = 0;
        }
    }
    freq[i] = counter;
}

for (int i = 0; i < intNumberOfNumbers; i++)
{
    if (freq[i] > 0)
    {
        Console.WriteLine($"Number {doubles[i]} appears {freq[i]} times");
    }
    
}
