// принимает число на вход + выдает сумму чисел от 1 до а

Console.WriteLine("число  ");
int num = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     int sum = default;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;

//     }
//     return sum;

// }
// int result = SumNumbers(num);
// Console.WriteLine ($"{result}");

int SumNumbers(int num)
{
    int sum = default;
    int counter = 1; 
    while(counter <= num) 
    {
        
        sum = sum + counter;
        counter++;
    }

    return sum;

}
int result = SumNumbers(num);
Console.WriteLine ($"{result}");


