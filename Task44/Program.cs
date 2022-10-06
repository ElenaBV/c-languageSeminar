//  выведите первые н чисел фибонначчи первые - 0,1

Console.WriteLine("Введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintFibonacci (int number )
{
    int numA = 0;
    int numB = 1;
    

    Console.Write($"{numA} {numB} ");

    for (int i = 2; i <number; i++)
    {
        
        int nextNum = numA +numB;
        Console.Write($"{nextNum} ");
        numA = numB;
        numB = nextNum;
    }
}
PrintFibonacci(number);