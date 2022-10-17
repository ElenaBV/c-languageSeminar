// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите значение ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = AkkermanFunction(numberA, numberB);
Console.WriteLine($"{result}");

int AkkermanFunction(int numA, int numB)
{
   
    if (numA == 0) return numB +1;
    if (numA > 0 && numB == 0 ) return AkkermanFunction (numA - 1,1);
    if (numA > 0 && numB > 0 ) return AkkermanFunction(numA-1, AkkermanFunction (numA, numB - 1));
    return AkkermanFunction(numA,numB);
}