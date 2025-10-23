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

string originalOrder = string.Empty;
for (int i = 0; i < intNumberOfNumbers; i++)
{
    originalOrder += doubles[i].ToString() + " ";
}

Console.WriteLine(originalOrder);

string reverseOrder = string.Empty;
double[] revertOrder = (double[])doubles.Clone();

for (int i = 0; i < intNumberOfNumbers/2; i++)
{
    double temp = 0;
    temp = revertOrder[i];
    revertOrder[i] = revertOrder[intNumberOfNumbers - 1 - i];
    revertOrder[intNumberOfNumbers - 1 - i] = temp;
}

for (int i = 0; i < intNumberOfNumbers; i++)
{
    reverseOrder += doubles[i].ToString() + " ";
}

Console.WriteLine(reverseOrder);

bool isSorted = false;
double[] ascSort = (double[])doubles.Clone();

while (!isSorted)
{
    isSorted = true;
    for (int i = 0; i < intNumberOfNumbers; i++)
    {
        double temp = 0;
        if (i + 1 < intNumberOfNumbers)
        {
            if (ascSort[i] > ascSort[i + 1])
            {
                temp = ascSort[i + 1];
                ascSort[i + 1] = ascSort[i];
                ascSort[i] = temp;
                isSorted = false;
            }
        }        
    }
}

string sortedOrder = string.Empty;

for (int i = 0; i < intNumberOfNumbers; i++)
{
    sortedOrder += ascSort[i].ToString() + " ";
}

Console.WriteLine(sortedOrder);

for (int i = 0; i < intNumberOfNumbers / 2; i++)
{
    double temp = 0;
    temp = ascSort[i];
    ascSort[i] = ascSort[intNumberOfNumbers - 1 - i];
    ascSort[intNumberOfNumbers - 1 - i] = temp;
}

string sortedOrderDesc = string.Empty;

for (int i = 0; i < intNumberOfNumbers; i++)
{
    sortedOrderDesc += ascSort[i].ToString() + " ";
}

Console.WriteLine(sortedOrderDesc);


