// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Console.Write("Введите строку:  ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец:  ");
int columns1 = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
int SearchElement(int[,] matrix)
{
    int element = default;
    if (rows1 <= matrix.GetLength(0) && columns1 <= matrix.GetLength(0))
    {
        for (int i = rows1; i < matrix.GetLength(0); i++)
        {
            for (int j = columns1; j < matrix.GetLength(1); j++)
            {
                if (i == rows1 && j == columns1) element = matrix[i, j];
            }
        }
    }
    else return -1;
    return element;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2d);
int searchElement = SearchElement(array2d);
if (searchElement > 0)Console.WriteLine("Значение этого элемента   " + searchElement);
else Console.WriteLine("Нет такого элемента ");





// if (searchMatrix) Console.WriteLine($"{searchMatrix}");
// else Console.WriteLine("No");

