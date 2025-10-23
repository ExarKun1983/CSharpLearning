int[] arr1 = { 1, 3, 5, 7 };
int[] arr2 = { 3, 5, 8, 9 };

int[] result = new int[arr1.Length];

int[] fResult = new int[arr1.Length];

int counter = 0;
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            result[counter++] = arr1[i]; break;
        }
    }
}

bool isDuplicate = false;

for (int i = 0; i < result.Length; i++)
{

    for (int j = 0 + i + 1; j < result.Length; j++)
    {
        if (result[i] == result[j])
        {
            isDuplicate = true;
        }
    }

    if (!isDuplicate)
    {
        fResult[i] = result[i];
        isDuplicate = false;
    }
}

for (int i = 0; i < counter; i++)
{
    Console.WriteLine(result[i]);
}





