// число на вход, на выход количество цифр в числе

Console.WriteLine("число  ");
int number = Convert.ToInt32(Console.ReadLine());

int QuintityOfNumber(int num)
{
    int i = 0;
    while (num  > 0)
    {
        int result = num/10;
        i++;
        num = result;
        
    }
return i;
}
int result = QuintityOfNumber(Math.Abs(number));
Console.WriteLine ($"{result}");
