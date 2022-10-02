// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 

Console.WriteLine("Введите координаты 3- х точек  ");
Console.Write("x1:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("x3:  ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y3:  ");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1:  ");


double distance(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
{
    double result = Math.Sqrt(Math.Pow((arg4 - arg1), 2) + Math.Pow((arg5 - arg2), 2)+ Math.Pow((arg6 - arg3),2));
    return result;
}
double result = Math.Round(distance(x1, x2,x3, y1, y2,y3), 2, MidpointRounding.ToZero);

Console.WriteLine($"Итоговое  значение {result}");

