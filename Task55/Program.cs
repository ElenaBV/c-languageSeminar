// Задайте двумерный массив Напишите программу, которая заменяет строки на столбцы
// В случае, если это невозможно , программа должна вывести сообщения для пользователя


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
int[,] matrix2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix2d);
int[,] newMatrixReplaseRowsToColumns = NewMatrixReplaseRowsToColumns(matrix2d);
PrintMatrix(newMatrixReplaseRowsToColumns);
bool CheckMatrix(int[,] matrix2d)

{
    return matrix2d.GetLength(0) == matrix2d.GetLength(1);
}
if (CheckMatrix(matrix2d))
    PrintMatrix(NewMatrixReplaseRowsToColumns(matrix2d));
else Console.WriteLine("невозможно изменить");

int[,] NewMatrixReplaseRowsToColumns(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] newarray = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newarray[i, j] = matrix[j, i];
        }
    }return newarray;

}




