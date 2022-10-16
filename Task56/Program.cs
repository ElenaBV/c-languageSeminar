// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


int[] FindMinSumOfElementsInRow(int[,] matrix)
{

    int[] array = new int[3];
    int k = 0;
    while (k < array.Length)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = default;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                sum = matrix[i, j] + sum;

            }
            array[k] = sum;
            k++;
        }
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

void ShowRowWithLessSum(int[] array)
{
    int k = 0;
    int min = array[k];
    while (k < array.Length)
    {
        if (array[k] < min)
        {
            min = array[k];
            
        }
        k++;
    }
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {k}");
}

int[,] matrix2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix2d);
Console.WriteLine();
FindMinSumOfElementsInRow(matrix2d);
int[] array = FindMinSumOfElementsInRow(matrix2d);
PrintArray(array);
ShowRowWithLessSum(array);




