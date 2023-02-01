// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int matrixRows = 5;
int matrixcolums = 5;
int matrixMinValue = 1;
int matrixMaxValue = 11;

int[,] matrix = CreateMatrix(matrixRows, matrixcolums, matrixMinValue, matrixMaxValue);
PrintMatrix(matrix);
if (matrixRows == matrixcolums)
{
    Console.WriteLine(string.Empty);
    int[,] newMatrix = ChangeRowsColumsMatrix(matrix);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Введены разные значения строк и столбцов");

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] ChangeRowsColumsMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++) // -1 и +1 это мы исключаем перезапись первого и посленего элемента. Чтобы цифры не смещались джи равно и 
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix [i,j];
            matrix [i,j] = matrix [j,i];
            matrix [j,i] = temp;
        }
    }
    return newMatrix;
}

// int[,] ChangeRowsColumsMatrix(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[i, j] = matrix[j, i];
//         }
//     }
//     return newMatrix;
// }