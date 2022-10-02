// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int number)
{
    int lastDigit = number / 10;
    int firstDigit = number / 100;
    return lastDigit - (firstDigit * 10);
}

int result = ShowSecondDigit(number);
if (number > 99 && number < 999)
{
    Console.WriteLine($"Итоговое число от {number} = {result}");
}
else Console.WriteLine("Не трехзначное число");
