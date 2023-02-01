// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int matrixRows = 5;
int matrixcolums = 5;
int matrixMinValue = 1;
int matrixMaxValue = 11;

int[,] matrix = CreateMatrix(matrixRows,matrixcolums, matrixMinValue, matrixMaxValue);
PrintMatrix(matrix);
ChangeFirstAndlastRows(matrix);
Console.WriteLine(string.Empty);
PrintMatrix(matrix);

int[,] CreateMatrix (int rows, int columns, int min, int max)
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

void ChangeFirstAndlastRows(int [,] matrixforChange)
{
    int firstRow = 0;
    int lastRow = matrixforChange.GetLength(0)-1;
    for (int i = 0; i < matrixforChange.GetLength(1); i++)
    {
       int temp = matrixforChange[firstRow, i];
       matrixforChange[firstRow, i] = matrixforChange[lastRow, i];
       matrixforChange[lastRow, i] = temp;
    }
}