// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] arrayOrigin = CreateArrayRndInt(10, -3, 5);
PrintArray(arrayOrigin);
int[] arrayCopy = CopyArray(arrayOrigin); // передача массива 
arrayCopy[0]=30; // проверка что создалась копия у которого первый элемент 30
PrintArray(arrayCopy);

int[] CopyArray (int[] arr) // передается массив 
{
    int[] result = new int[arr.Length]; // создание нового массива, с длинной массива которого передали 
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i]; // создали новый массив и прировнаяли его к старому
    }
    return result;
}

int[] CreateArrayRndInt (int size, int min, int max) 
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(min,max + 1); 
    }
    return arr;
}

void PrintArray(int[] arr) 
{
   Console.Write("[");
   for (int i = 0; i < arr.Length; i++) 
    {
       if(i < arr.Length - 1) Console.Write(arr[i] + ","); 
       else Console.Write(arr[i]);
    }   
    Console.Write("]"); 
}
