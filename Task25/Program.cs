﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// проверить на б больше 0 


Console.WriteLine("число A ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число B ");
int numB = Convert.ToInt32(Console.ReadLine());

double degreeNumbers (int numA, int numB)
{
double degree = Math.Pow(numA, numB);
return degree;
}
double result = degreeNumbers(numA,numB);
Console.WriteLine ($"{result}");