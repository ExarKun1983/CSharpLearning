using System.Xml;

int[] numbers = { 4, 2, 4, 1, 2, 3, 1, 5 };


int[] tempResult = new int[numbers.Length];

int counter = 0;
for (int i = 0; i < numbers.Length; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j <= counter; j++)
    {
        if (numbers[i] == tempResult[j])
        {
            isDuplicate = true;
            break;
        }       
    }

    if (!isDuplicate)
    {
        tempResult[counter] = numbers[i];
        counter++;
    }
}

Array.Sort(tempResult, 0, counter);

for (int i = 0; i< counter; i++)
{
    Console.WriteLine($"{tempResult[i]}");
}

Console.ReadLine();