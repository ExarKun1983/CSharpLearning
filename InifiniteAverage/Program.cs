Console.WriteLine("How many numbers?");
string numberOfNumbers = Console.ReadLine();

if (!int.TryParse(numberOfNumbers, out int intNumberOfNumbers))
{
    Console.WriteLine("Invalid input for number of loops");
    return;
}

List<double> doubles = new List<double>();
for (int i = 0; i < intNumberOfNumbers; i++)
{
    Console.WriteLine($"Enter the number {i+1}:");
    string strNumber = Console.ReadLine();
    if (int.TryParse(strNumber, out int intNumber))
    {
        doubles.Add(intNumber);
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

double sum = 0;
foreach (double ddouble in doubles)
{
    sum += ddouble;
}

double result = sum / doubles.Count;

Console.WriteLine($"The average is {result}");