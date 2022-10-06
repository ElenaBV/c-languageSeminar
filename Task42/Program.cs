// Напишите программу, которая будет преоброзовывать десятичное число в двоичное
// 13 - 1101
// 3 - 11
// 2-10
// остаток от деления на два // потом нужно переверноуть 

Console.WriteLine("Введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertNumberToBinarySystem(int number)
{
    int binaryNum = 0;
    int counter = 1;
    while (number > 0)
    {
        binaryNum = binaryNum + number % 2 * counter;
        counter = counter * 10;
        number = number / 2;
    }
    return binaryNum;
}
int binaryNum = ConvertNumberToBinarySystem(number);
Console.WriteLine($"{number} - {binaryNum} ");
