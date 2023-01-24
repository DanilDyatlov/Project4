// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 1, 3);
PrintArrayDouble(array);
double maxArr = MaxArray(array);
Console.WriteLine($"Максимальный элемент массива: {maxArr}");
double minArr = MinArray(array);
Console.WriteLine($"Минимальный элемент массива: {minArr}");
Console.WriteLine($"Разница: {maxArr - minArr}");


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min; // получение чисел, не принимает никакие значения, чтобы работало нужно *(max - min) + min
        arr[i] = Math.Round(num, 1); // округление 
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double MaxArray(double[] array)
{
    double maxArr = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArr) maxArr = array[i];
    }
    return maxArr;
}

double MinArray(double[] array)
{
    double minArr = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minArr) minArr = array[i];
    }
    return minArr;
}