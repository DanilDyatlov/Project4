﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int prodNumbers = ProdNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {prodNumbers}");

int ProdNumbers(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
        // sum += i
    }
    return prod;
}
