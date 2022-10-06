//Напишите программу которая перевернет одномерный массив (последний на первое и наоборот )

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


int [] ReverseMassiv (int[]array)
{
    int i = 0;
    int j = array.Length - 1;
    int obj = 0;
    if(array[1]< array[2]) 
    {
        obj = array[i];
        array[i] = array[j];
        array[j] = obj;
        i++;
        j--;

    }
    return array;
}
int [] array = CreateArrayRndInt(4,1,10);
PrintArray(array);
int [] reverseMassiv = ReverseMassiv(array);
PrintArray(array);
