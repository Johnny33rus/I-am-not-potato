int[] array = { 4, 1, 6, 3, 5 };
for (int i = 0; i < array.Length; i++)
{
    int v = array[i];
    int j = i - 1;
    while (j >= 0 && array[j] > v)
        {
        array[j+1] = array[j];
        j--;
        }
        array[j+1] = v;
}

for (int i = 0; i < array.Length; i++)
    {
    Console.WriteLine(array[i]);
    }