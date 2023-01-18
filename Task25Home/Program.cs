// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = numberA;
for (int i = 1; i < numberB; i++) // 3х3х3х3х3
{
    degree = degree * numberA;
}
Console.WriteLine("A в степени B равно:" + degree);