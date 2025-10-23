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

double sum = 0;
double product = 1;
for (int i = 0; i < intNumberOfNumbers; i++)
{
    sum += doubles[i];
    product *= doubles[i];
}

Console.WriteLine($"The sum is {sum} and the product is {product}");
