// одномерный массив из 123 случайных чисел найти кол-во элементовб которые лежат в отрезке  10 -99 

int[] NewArray(int size, int min, int max)
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

int QuantityArrayRange(int[] array, int minA, int maxA)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>= minA && array[i] <= maxA) counter++;
    }
    return counter;
}

int[] arr = NewArray(123,0,1000);
PrintArray(arr);
int quantityArrayRange = QuantityArrayRange(arr, 10,99);
Console.WriteLine($"кол-во элементов -  {quantityArrayRange}");

