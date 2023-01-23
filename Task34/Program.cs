// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива (положительное число): ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0) Console.WriteLine("Неверное число");

int[] array = CreateRndArray(size, 100, 1000);
PrintArray(array);
Console.WriteLine();
int findEvenNumbArr = FindEvenNumbArr();
Console.WriteLine($"Колличество чиселе: {array.Length}, четные числа из них: {findEvenNumbArr}");


int[] CreateRndArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int FindEvenNumbArr()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

