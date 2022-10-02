// по номеру четверти показать диапозон возможных координат точек в этой четверти ХУ

Console.WriteLine("Введите номер четверти  ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = Quarter(quarter);
Console.WriteLine(result);


string Quarter(int quater1)
{
    if (quarter == 1) return "x > 0 y > 0";
    if (quarter == 2) return "x < 0  y > 0";
    if (quarter == 3) return "x < 0  y < 0";
    if (quarter == 4) return "x > 0  y < 0";
    return "Некоректные координаты  ";

}
