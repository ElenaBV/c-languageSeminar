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




double SumAverageColumElement(double[,] matrix)
{
    double counter = default;
    double result = default;


        {
            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    counter = counter + matrix[i, j];
                }
                result = counter / matrix.GetLength(0);
            }

        }
        return result;

}


double[,] array2d = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2d);

double sumAverageColumElement=SumAverageColumElement(array2d);
 Console.WriteLine("Значение этого элемента   " + sumAverageColumElement);

