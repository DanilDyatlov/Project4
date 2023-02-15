// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1); // рекурсия, по одной отнимаем число, когда дойдет до 0 метод остановиться, если поменять 14 и 15 стройчку будет записывать в другом порядке 
    Console.Write($"{num} ");
}