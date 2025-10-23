using System.Numerics;

int[] arr1 = { 1, 3, 5, 7 };
int[] arr2 = { 3, 5, 8, 9 };

int[] temp = new int[arr1.Length + arr2.Length];

int i = 0;
for (i = 0; i < arr1.Length; i++)
{
    temp[i] = arr1[i];
}

for (int j = 0; j< arr2.Length; j++)
{
    temp[j+i] = arr2[j];
}

int[] final = new int[temp.Length];

int position = 0;
for (int j = 0; j < temp.Length; j++)
{
    bool isUnique = true;
    for (int k = 0; k < position; k++)
    {
        if (temp[j] == final[k])
        {
            isUnique = false;
        }
       
    }
    if (isUnique == true)
    { 
        final[position++] = temp[j];
    }
}


bool isSorted = false;

while(!isSorted)
{
    isSorted = true;
    for (int j = 0; j < position-1; j++)
    {
        if (final[j] > final[j+1])
        {
            int tmp = final[j + 1];
            final[j + 1] = final[j];
            final[j] = tmp;
            isSorted = false;
        }
    }
}

for (int j = 0; j < position; j++)
{
    Console.WriteLine(final[j]);
}


