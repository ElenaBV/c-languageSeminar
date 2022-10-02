// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
   number = number / 10;
 
}
  int result2 = ShowThirdDigit(number);
int ShowThirdDigit(int number)
{
    return number % 10;

}
int result = ShowThirdDigit(number);

if (number / 100 > 0) Console.WriteLine($"Итоговое число от {number} = {result}");
else Console.WriteLine("третьей цифры нет");

