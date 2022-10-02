// Выводит 3 - значное число , удаляет вторую цифру этого числа

// 456 - 46 

int number = new Random().Next(100, 1000);
int RemoveSecondDigit(int number)
{
    // int lastDigit = number % 10;
    // int firstDigit = number / 100;
    // return firstDigit * 10 + lastDigit;
    // Более простое решение
    return number / 10 % 10;
}
int result = RemoveSecondDigit(number);
// вызываем метод этой строкой 

Console.WriteLine($"Итоговое число от {number} = {result}");

