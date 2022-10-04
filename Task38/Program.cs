// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min,2, MidpointRounding.AwayFromZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
double[] MinMaxArray(double[] array)
{
    double maxA = array[0];
    double minA = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxA) maxA = array[i];
        else if (array[i] < minA) minA = array[i];

    }

    return new double[] { maxA, minA };


}



double[] array = CreateArrayRndInt(4, 0, 3);
PrintArray(array);
double[] minMaxArray = MinMaxArray(array);
Console.WriteLine($"Максимальное= {minMaxArray[0]}, Минимальное = {minMaxArray[1]}");
Console.WriteLine($"Разница {minMaxArray[0] - minMaxArray[1]}");


