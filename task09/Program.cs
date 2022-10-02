// случайное число из отрезка от 10 - - 99 показывает наибольшую цифру числа 

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число тиз отрезка 10 -- 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра {number} = {firstDigit} ");
// else Console.WriteLine($"Наибольшая цифра {number} = {secondDigit} ");

// int maxDigit = firstDigit;
// if (secondDigit > firstDigit) maxDigit = secondDigit;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;  тернарный оператор - условный оператор 

//  В методе не должно быть консоли, он для вычеслений 
// Создаем метод для вычеслений
// 1 цифра int firstDigit = num / 10;
// 2 цифра int secondDigit = num % 10;
// если (условие ) то верни 0 ( здесь подходит по условиям, потому что нет отрицательных чисел)
// if (firstDigit == secondDigit) return 0;
// тернарным оператором с возвратом по факту вычеслений - если 1 больше 2? тогда 1 чилсло в противном случае (:) 2
//  return firstDigit > secondDigit ? firstDigit : secondDigit;
// Метод завершен 
// вводим переменные числа  для решения через рандомайзер в диапозоне 10 -99 
// int number = new Random().Next(10, 100);
// вводим переменную махдигит заменяя на то, что было в методе 
// int maxDigit = MaxDigit (number);
// в линию не числовую (вместо int, так как надо чтобы работало цифры равны вводим тернарным методом условия если )
// string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
// 
// Console.WriteLine($"Наибольшая цифра {number} = {result} ");


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if (IsEqualDigit(firstDigit, secondDigit)) return 0;
    // Здесь важно, чтобы возвратом было число! это не консоль!
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
bool IsEqualDigit(int num1, int num2)
{
    return num1 == num2;
}
int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра {number} = {result} ");

// 