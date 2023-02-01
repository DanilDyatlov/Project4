// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
Console.Write("Введите порядковый номер элемента в строке: ");
int numRow = Convert.ToInt32(Console.ReadLine());
int rowIndex = numRow - 1;
Console.Write("Введите порядковый номер элемента в столбце: ");
int numcolumn = Convert.ToInt32(Console.ReadLine());
int columnIndex = numcolumn - 1;

bool elementExist = ElementExist(array2d, rowIndex, columnIndex);
if (elementExist)
{
    Console.WriteLine($"{numRow},{numcolumn} -> {array2d[rowIndex, columnIndex]}");
}
else
{
    Console.WriteLine($"{numRow},{numcolumn} -> такого элемента в массиве нет");
}
Console.WriteLine();
Console.WriteLine("Массив: ");
PrintMatrix(array2d);


bool ElementExist(int[,] arr, int indexOfRow, int indexOfColumn)
{
    if (indexOfRow >= 0 && indexOfRow < arr.GetLength(0) && indexOfColumn >= 0 && indexOfColumn < arr.GetLength(1)) 
    return true;
    return false;
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},"); // число 5 это отступы 
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}
