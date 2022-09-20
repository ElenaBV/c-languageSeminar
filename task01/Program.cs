Console.WriteLine("Введите число 1 для проверки");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 для проверки");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number2 * number2;
if(number1 == square)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}