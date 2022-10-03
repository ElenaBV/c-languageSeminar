Console.WriteLine("введите число для поиска ");
int numA = Convert.ToInt32(Console.ReadLine());


int [] NewArray(int size, int min, int max)
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
bool SearchArray(int[]array, int numA)
{
    bool searchArray = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == numA) 
        {
            searchArray = true;
            break;

        }
    }
    return searchArray;

}

int [] array = NewArray(5,0,10);
PrintArray(array);
bool searchArray = SearchArray(array, numA);

if (searchArray) Console.WriteLine("Yes");
else Console.WriteLine("No");