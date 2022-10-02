// введите число N произведение от1 до N

Console.WriteLine("число  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
{
    int result = DigitMultiplication(number);
    Console.WriteLine($"{result}");
}
else Console.WriteLine("wrong");

int DigitMultiplication ( int num)
{
    int multiplic = 1;
for (int i = 1; i <= num ; i++)
{
    multiplic = multiplic * i;
}
return multiplic;
}
