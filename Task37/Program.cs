int[] CreateArrayRndInt(int size, int min, int max)
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
int[] MultiplicateFirstLastNum(int[] array)
{
    int lengthNewArray = default;
    if (array.Length % 2 == 0) lengthNewArray = array.Length / 2;
    else lengthNewArray = (array.Length / 2) + 1;
    int[] newArray = new int[lengthNewArray];
    for (int i = 0; i < newArray.Length; i++) // [1,4,2,3,6]
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (newArray.Length%2 ==1) newArray[(newArray.Length -1)] = array[array.Length/2];
    return newArray;
}
int [] array = CreateArrayRndInt(5,1,6);
PrintArray(array);
int [] multiplicateFirstLastNum = MultiplicateFirstLastNum(array);
PrintArray(multiplicateFirstLastNum);
