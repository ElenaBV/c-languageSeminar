// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// найти каждую цифру и сравнивать 1 и 5 2 и4 если 1=5 2=4  деление и остаток от деления //сделать реверсию 

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int palindrome(int number)
{
    int lastDigit = number % 10;
    int firstDigit = number / 10000;
    int secondDigit = (number / 1000 % 10);
    int preLastDigit = (number / 10) % 10;
    int middleDigit = (number / 100) % 10;
    return (lastDigit * 10000) + (preLastDigit * 1000) + (middleDigit * 100) + (secondDigit * 10) + (firstDigit * 1);
}
int result = palindrome(number);

if (result == number) Console.WriteLine("Yes");
else Console.WriteLine("No");





