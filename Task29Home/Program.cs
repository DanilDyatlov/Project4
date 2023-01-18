// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = CrateArray(8);
PrintArray(array);

int[] CrateArray (int size) // создаем массив в методе, т.к. создаем массив то используем инт
{
    int[] array = new int[size]; // размер массивая задается size 
    Random rnd = new Random(); 
    for (int i =0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,100); 
    }
    return array;
}

void PrintArray(int[] arr) 
{
    for (int i =0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[" + arr[i] + ", ");
        else if (i == arr.Length - 1) Console.Write(arr[i] + "]");
        else Console.Write(arr[i] + ", ");
    }
}
