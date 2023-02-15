// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));

int SumDigits(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumDigits(num / 10);
}