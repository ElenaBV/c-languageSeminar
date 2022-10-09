// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
var rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) //rows (0)
{
for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
{
matrix[i, j] = i+j;
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
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
else Console.Write($"{matrix[i, j], 4}");
}
Console.WriteLine("|");
}
}


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);