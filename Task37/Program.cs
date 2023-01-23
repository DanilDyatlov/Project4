// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = CreateArrayRndInt(10, -5, 5);
PrintArray(array);
int[] newArr = MultiplyElemArray(array);
Console.WriteLine();
PrintArray(newArr);


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

// int[] MultiplyElemArray(int[] arr) // arr чтобы не было пересечений 
// {
//     int size = 0;
//     if (arr.Length % 2 == 0) size = arr.Length / 2;
//     else size = arr.Length / 2 + 1; // +1 когда нечетные
//     int[] resArr = new int[size]; // создание массива 
//     for (int i = 0; i < size; i++)
//     {
//         resArr[i] = arr[i] * arr[(arr.Length-1)-i];
//     }

// }

int[] MultiplyElemArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size +=1; // если массив нечетный увеличиваем размер на 1 
    int[] newArr = new int[size]; //создаем полученный  массив 
    for (int i = 0; i < size; i++)
    {
        if(i != arr.Length - 1 -i) //!= знак "не равно 0"
        newArr[i] = arr[i] * arr[arr.Length-1-i];
        else newArr[i] = arr[i];
    }
    return newArr;
}


// if (arr.Length % 2 == 1) newArr[newArr.Length - 1] = arr[arr.Length / 2]; присваиваем середину в конец 