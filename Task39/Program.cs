// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int[] array = CreateRndArray(4, -10, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
Array.Reverse(array); // встроеный метод
PrintArray(array);
// ReverseArrayVersion2(array); // повторили встроеный метод 
// PrintArray(array);

int[] CreateRndArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 10);
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
    Console.WriteLine("]");
}

// Array.Reverse(array); метод встроеный который переворачивает массив 
// [1 2 3 4 5] -> [5 4 3 2 1]
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++) // делем на два чтобы найти середину 
    {
        int temp = arr[i]; // temp временная переменная 
        arr[i] = arr[arr.Length - 1 - i]; // -i чтобы было смещение 
        arr[arr.Length - 1 - i] = temp;
    }
}

// void ReverseArrayVersion2(int[] array) реализация встроеного метода 
// {
//     int index1 = 0;
//     int index2 = array.Length - 1;

//     while (index1 < index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;
//         index1++;
//         index2--;
//     }
// }