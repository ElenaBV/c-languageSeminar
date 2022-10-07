// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите b1 : ");
// double NumB1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1 : ");
// double NumK1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2 : ");
// double NumB2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2 : ");
// double NumK2 = Convert.ToInt32(Console.ReadLine());

// double x= (NumB2-NumB1)/(NumK1-NumK2);
// double y = NumK1*x+NumB1;
// Console.WriteLine($"точку пересечения двух прямых  {x},{y}");

double[] CreateArray(int size)
{
    double[] array = new double[size];
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
double[] FillNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите числа  ");
        int numA = Convert.ToInt32(Console.ReadLine());
        array[i] = numA;
    }

     return array;
 }



 double[] array = CreateArray(4);
 FillNewArray(array);
 double x = (array[2] - array[0]) / (array[1] - array[3]);
 double y = array[1] * x + array[0];
 Console.WriteLine($"точку пересечения двух прямых  {x},{y}");
 PrintArray(array);
