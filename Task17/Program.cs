// на вход - координаты ХУ ХУ!=0 и выдает номер четверти плоскости в которой находится эта точка 

Console.WriteLine("Введите координаты точки ");
Console.Write("X:  ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:  ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "Некоректные координаты  " : quarter);
string quarterStr = QuarterStr(xC, yC);
Console.WriteLine(quarterStr);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;

}
string QuarterStr(int x, int y)
{
    if (x > 0 && y > 0) return "First";
    if (x < 0 && y > 0) return "Second";
    if (x < 0 && y < 0) return "Third";
    if (x > 0 && y < 0) return "Fourth";
    return "Некоректные координаты  ";

}
