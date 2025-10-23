using System.Net;
using System.Runtime.CompilerServices;

int[] numbers = { 5, 2, 9, 1, 5, 6 };

int min=0;
int max=0;


for (int i = 0; i< numbers.Length; i++)
{
    if (i==0)
    {
        min = numbers[i];
        max = numbers[i];
    }
    else
    {
        if (numbers[i] < min) min = numbers[i];
        if (numbers[i] > max) max = numbers[i];
    }

}

Console.WriteLine($"Min: {min}, Max: {max}");

for (int i = 0;i< numbers.Length/2;i++)
{
    int temp = 0;
    temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length -1 - i] = temp;
}

Console.ReadLine();

bool isSorted = false;
while (!isSorted)
{
    isSorted = true;
    for (int i = 0; i < numbers.Length; i++)
    {
        int temp = 0;
        if (i + 1 < numbers.Length)
        {
            if (numbers[i] > numbers[i + 1])
            {
                temp = numbers[i + 1];
                numbers[i + 1] = numbers[i];
                numbers[i] = temp;
                isSorted = false;
            }
        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

//List<int> list = new List<int>();
//for (int i = 0; i < numbers.Length; i++)
//{
//    list.Add(numbers[i]);
//}

//list.RemoveAll(x => x ==max);

int counter = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == max)
    {
        counter++;
    }
}

for (int i = 0;i<numbers.Length - counter; i++)
{
    Console.WriteLine(numbers[i]);
}