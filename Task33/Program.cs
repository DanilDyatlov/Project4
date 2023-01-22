// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
int[] array = CreateArrayRndInt(12, -9, 9); //вызов метода 12 - кол во элементов -9 и 9 мин и макс 
PrintArray(array);

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


bool GetNumInArray (int[] arr, int num) // создание метода с данными 
{
    for (int i = 0; i < arr.Length; i++) // i - это счетчик 
    {
        if(arr[i] == num)
            return true;
    }
    return false;
}
Console.WriteLine("Введите число, которое хотите найти в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
bool getNumInArray = GetNumInArray(array, number);
if (getNumInArray)
{
    Console.Write($"Число {number} есть в массиве:");
    PrintArray(array);
}
else
{
    Console.Write($"Числа {number} нет в массиве:");
    PrintArray(array);
}




