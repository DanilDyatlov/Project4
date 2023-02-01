// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// [ , ] указывает на двумерный массив, между ними размерность, 1 это строки 2 столбцы 
{
    int[,] matrix = new int[rows, columns]; // создание массива 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // создаем 2 цикла так как две координаты. matrix.GetLength(0) 0 это строки, 1 это столбцы 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // с таким расположением идет строка столбец столбец. 
        // Чтобы поменять на столбец строка строка, нужно менять буквы и цифры 
        {
            matrix[i, j] = rnd.Next(min, max + 1); // заполняем случайными цислами 
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},"); // число 5 это отступы 
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2D);