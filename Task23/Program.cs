// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

void cube(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        int result = counter * counter*counter;
        Console.WriteLine($"{counter,2} {result,5}");
        counter++;
    }
}
if (num>0) cube(num);
else Console.WriteLine("Incorrect");