// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите значение ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = GetPowOfNumber(numberA,numberB);
Console.WriteLine(result);

int GetPowOfNumber (int numA, int numB)
{
    // if (numN == 0 ) return 1 ;
    // int res = numberM; 
    // res *= GetPowOfNumber(numM,numN-1);
    // return res;
    return numB == 0? 1 : numA *GetPowOfNumber (numA,numB-1);

}


