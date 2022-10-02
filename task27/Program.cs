// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("число  ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int result = num % 10;
        sum = sum + result;
        num = num/10;
        
    }
    return sum;
}
int result = SumNumbers(number);
Console.WriteLine($"{result}");
