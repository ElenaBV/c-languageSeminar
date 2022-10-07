// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Уточните, какое количество чисел будете вводить: ");
int numA = Convert.ToInt32(Console.ReadLine());


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
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
int [] FillNewArray (int[]array)
{
    
    
   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите числа  ");
        int numB = Convert.ToInt32(Console.ReadLine());
        array[i] = numB;
    }

    return array;
}
void CountNumberOverZero(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
Console.WriteLine($"Количество больше нуля - {count}");
}

int[] array = CreateArrayRndInt(numA);
FillNewArray(array);
PrintArray(array);
CountNumberOverZero(array);


