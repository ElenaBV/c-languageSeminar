// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sumn = SumOfDigits(numberA, numberB);
Console.WriteLine($"{sumn}");



int SumOfDigits(int numA, int numB)
{
    int sum = numA;

    if (numA < numB)
    {
        sum += SumOfDigits(numA + 1, numB);

    }
    return sum;
}

