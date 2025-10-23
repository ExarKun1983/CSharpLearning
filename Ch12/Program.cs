int[] arr1 = { 1, 2, 3, 4, 5 };
int k = 2;

int counter = 0;
for (int i = 0;i < k;i++)
{
    int temp = arr1[arr1.Length - 1];
    for (int j = arr1.Length - 1; j > 0 ;j--)
    {
        arr1[j] = arr1[j-1];
    }
    arr1[0] = temp;
}
