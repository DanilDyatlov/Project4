// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите колличество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0)
{
    int[] creatEnterArray = CreatEnterArray(size);
    PrintArray(creatEnterArray);
    int positiveNumbers = PositiveNumbers(creatEnterArray);
    Console.Write($"Положительные числа: {positiveNumbers}");
}
else Console.WriteLine("Введите другое число: ");

int[] CreatEnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Какие числа хотите проверить?: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}