// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("число A ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число B ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB > 0)
{
    int result = DegreeNumbers(numA, numB);
    Console.WriteLine($"{result}");
}
else Console.WriteLine("wrong");

int DegreeNumbers(int numA, int numB)

{
    int degree = numA;
    int count = 1;

    while (count < numB)
    {
        degree = degree * numA;
        count++;
    }
    return degree;
}


