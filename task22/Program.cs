
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

void SqureTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        int result = counter * counter;
        Console.WriteLine($"{counter} = {result}");
        counter++;
    }
}
if (num>0) SqureTable(num);
else Console.WriteLine("Incorrect");

