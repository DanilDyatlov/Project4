// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt (int size, int min, int max) // создание метода с данными 
{
    int[] arr = new int[size]; // создание массива и его размер 
    Random rnd = new Random(); //создание случайных чисел
    for (int i = 0; i < arr.Length; i++) // i - это счетчик 
    {
        arr[i] = rnd.Next(min,max + 1); // метод некст, + 1 чтобы все числа входили в диапазон  
    }
    return arr;
}

void PrintArray(int[] arr) // метод печати массива 
{
   Console.Write("[");
   for (int i = 0; i < arr.Length; i++) 
    {
       if(i < arr.Length - 1) Console.Write(arr[i] + ","); // чтобы запятые были у всех элементов кроме одного, - 1 это последний элемент массива
       else Console.Write(arr[i]);
    }   
    Console.Write("]"); 
}

int GetSumPositiveElem(int[] arr) // создаем метод и передаем в него int[] arr массив
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr) // создаем метод и передаем в него int[] arr массив
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9); //вызов метода 12 - кол во элементов -9 и 9 мин и макс 
PrintArray(array);
int sumPositive = GetSumPositiveElem(array); // создали переменные  с вызовом метода 
int sumNegative = GetSumNegativeElem(array);

Console.WriteLine($"Сумма положительных элементов {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов {sumNegative}");

// int[] GetSumPositiveNegativeElem(int[] arr) 
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) sumPos += arr[i];
//         else if (arr[i] < 0) sumNeg += arr[i];
//     }
//     return new[]{sumPos, sumNeg};
// }
// int[] sumPositiveNegative = GetSumPositiveNegativeElem(array)
// Console.WriteLine($"Сумма положительных элементов {sumPositiveNegative[0]}"); 
// Console.WriteLine($"Сумма отрицательных элементов {sumPositiveNegative[1]}");