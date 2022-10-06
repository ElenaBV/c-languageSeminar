// Напишите программу, которая на вход принимает 3 числа и проверяет, может ли сущ треуголоьник со сторонами такой длины 
// теорема о неравенстве треугольника - каждая сторона треугольника меньше суммы двух других сторон


Console.WriteLine("Введите 3 числа: ");
Console.WriteLine("Введите 1 числo: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 числo: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 числo: ");
int sideC = Convert.ToInt32(Console.ReadLine());



bool CanTriangleExicte(int side1, int side2, int side3)
{
    return side1+side2>side3&&side2+side3>side1&&side1+side3>side2;
}
if (CanTriangleExicte (sideA, sideB, sideC)) Console.WriteLine($"Ok");
else Console.WriteLine("No");
