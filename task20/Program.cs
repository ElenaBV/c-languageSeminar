// Напишите программцу, кот на вход принимает координаты 2- х точек и дает расстояние между ними 
// А(3,6; B(2,1) = 5,09 
// A(7,-5);B(1,1) = 
// Math.Pow(2,10)
// double num = Math.Sqrt(10)
// double res = Math.Round(num, 2, MidPointRounding.ToZero);

Console.WriteLine("Введите координаты 2- х точек  ");
Console.Write("x1:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2:  ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance(int arg1, int arg2, int arg3, int arg4)
{
    double result = Math.Sqrt(Math.Pow((arg3 - arg1), 2) + Math.Pow((arg4 - arg2), 2));
    return result;
}
double result = Math.Round(distance(x1, x2, y1, y2), 2, MidpointRounding.ToZero);

Console.WriteLine($"Итоговое  значение {result}");

