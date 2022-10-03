// Программу для замены отрицательных чисел на положительные

int[] CreatArrayForChenging(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int[] ChangeNegativeToPositive(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)array[i] =  array[i] * (-1);
    }
return array;
}
int[] arr = CreatArrayForChenging(4, -8, 8);
PrintArray(arr);
int[] changeNegativeToPositive = ChangeNegativeToPositive(arr);
PrintArray(changeNegativeToPositive);

