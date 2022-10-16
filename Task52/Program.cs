// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
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
void PrintMatrix(double[,] matrix)
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


void SumAverageColumElement(double[,] matrix)
{

    double[] array = new double[4];
    for (int k = 0; k < array.Length; k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            double counter = default;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                counter = counter + matrix[j, i];
            }
array[k] = counter / matrix.GetLength(1);
        }
        
        Console.Write($"{array[k]}  ");
    }

}



double[,] array2d = CreateMatrixRndInt(3, 4, 0, 2);
PrintMatrix(array2d);
SumAverageColumElement(array2d);

// Console.WriteLine("Значение этого элемента   " + sumAverageColumElement);

