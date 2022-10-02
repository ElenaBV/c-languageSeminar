


int[] array = new int[8];
int[] resArray = GetArray(array);
PrintArray(array);
int[] GetArray(int[]arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]}");

    }
    Console.WriteLine();
}

