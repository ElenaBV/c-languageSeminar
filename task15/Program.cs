// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 & number < 6) Console.WriteLine("NO");

else if (number > 5 & number < 8) Console.WriteLine("Yes");

else
{
    Console.WriteLine("Wrong Number, Use from 1 to 7");
}