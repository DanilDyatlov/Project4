// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// int matrixRows = 5;
// int matrixcolums = 5;
// int matrixMinValue = 1;
// int matrixMaxValue = 11;

// int[,] matrix = CreateMatrix(matrixRows,matrixcolums, matrixMinValue, matrixMaxValue);
// PrintMatrix(matrix);
// Console.WriteLine(string.Empty);

// int[] firstArray = NumberDictionary(firstMatrix);
// PrintMatrix(firstArray);
// Console.WriteLine(string.Empty);

// Array.Sort(firstArray);
// PrintMatrix(firstArray);
// Console.WriteLine(string.Empty);

// Dictionary(firstArray);

// int[,] CreateMatrix (int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}  ");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[] NumberDictionary (int[,] matrix)
// {
//     int[] array = new int [matrix.Length];
//     int index = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             array[index] = matrix[i,j];
//             index++;

//         }
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + " ");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine();
// }

// void Dictionary (int[] array)
// {
//     int number = array[0];
//     int counr = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) count ++;
//         else 
//         {
//             Console.Writeline($"{number} -> {count}");
//             number = array[i];
//             count=1;
//         }
//     }
// }