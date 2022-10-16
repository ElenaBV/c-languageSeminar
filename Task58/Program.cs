// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
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

int [,] MultiplicationMatrixToMatrix (int [,] matrix2d , int[,] matrix2d1 )
{
    int [,] matrix = new int[2,2];
    for (int i = 0; i < matrix2d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2d1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2d1.GetLength(0); k++)
            {
                matrix[i,j] = matrix[i,j] + (matrix2d[i,k] * matrix2d1[k,j]);
            }
    
        }
    
    }
    return matrix;
}

int[,] matrix2d = CreateMatrixRndInt(2, 2, 1, 9);
int[,] matrix2d1 = CreateMatrixRndInt1(2, 2, 10, 20);
PrintMatrix(matrix2d);
Console.WriteLine();
PrintMatrix(matrix2d1);
Console.WriteLine();
int [,] multiplicationMatrixToMatrix = MultiplicationMatrixToMatrix(matrix2d,matrix2d1);
PrintMatrix(multiplicationMatrixToMatrix);
