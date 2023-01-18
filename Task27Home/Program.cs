// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (number < 0) Console.WriteLine("Неверный ввод");
while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма всех цифр в числе равна:"  + sum);


