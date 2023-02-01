// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7
// int[,] array2d = CreateMatrixRndint (4, 4, -5, 20);
// PrintMatrix(array2d);

// int[] indexMinVal = IndexMinVal(array2d);
// PrintArray(indexMinVal);

// int[,] cuttedArray = RemoveRowColumnCrossed(array2d,indexMinVal[0],indexMinVal[1]);
// PrintArray(cuttedArray);

// int[,] RemoveRowColumnCrossed(int[,] matrix, int removeRow, int removeColumn)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)-1];
//     int m =0;
//     int n=0;
//     for (int i = 0; i < newmatrix.GetLength(0); i++)
//     {
//         if (i==removeRow) m++;
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             if (j == removeColumn) n++;
//             newMatrix[i,j] = matrix[m,n];
//             n++;
//         }
//         m++;
//         n=0;
//     }
//     return newMatrix; 
// }
// int[] IndexMinVal(int[,] matrix)
// {
//     int min = matrix[0,0];
//     int indexRow = 0;
//     int indexColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             min = matrix[i,j];
//             int indexRow = i;
//             int indexColumn = j;
//         }
        
//     }
    
// }
// return new int[] {indexRow, indexColumn, min};

// int[,] CreateMatrixEvenNum(int rows, int columns, int min, int max)
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
//             Console.Write($"{matrix[i, j],3} ");
//         }
//         Console.WriteLine("]");
//     }
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
