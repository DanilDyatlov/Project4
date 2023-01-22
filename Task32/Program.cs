// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    Console.WriteLine("]"); 
}

void Inverse(int[] arr) // создаем метод и передаем в него массив созданый
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] *= -1; // замена знака 
    }
}
Inverse(array);
PrintArray(array);
