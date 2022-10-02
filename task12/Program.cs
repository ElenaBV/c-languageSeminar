// 2 числа на вход является ли второе кратно 1 если не кратно Б то остаток от отделения
// 34 , 5 - не кратно остаток - 4

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool isAliquot (int arg1, int arg2)
{
    // если выполняется, то записывает в правду// если нет - ложь
    return arg1 % arg2 == 0;
}

if(isAliquot(num1, num2)) Console.WriteLine ($"{num1} кратно {num2}");
else Console.WriteLine($"{num1} not {num2} Остаток: {num1 % num2} ");