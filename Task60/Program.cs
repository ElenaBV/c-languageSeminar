// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int first = new Random().Next(min, max + 1);

    for (int i = 0; i < matrix.GetLength(0); i++) //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)

            {

                matrix[i, j, k] = first + 1;
                first++;


            }
        }
    }
    return matrix;
}



void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)

            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],4}, ");
                else Console.Write($"{matrix[i, j, k],4}");
            }
        }
        Console.WriteLine("|");
    }
}


int[] MatriToOneRow(int[,,] matrix)
{
    int[] oneRowArray = new int[matrix.Length];
    int counter = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++) //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            
            for (int k = 0; k < matrix.GetLength(2); k++)

            {
                oneRowArray[counter] = matrix[i, j, k];
                counter++;
                
               
            }
        }
    }
    return oneRowArray;
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


int[,,] matrix2d = CreateMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(matrix2d);
Console.WriteLine();
int[] array = MatriToOneRow(matrix2d);
PrintArray(array);

