//Задача 66: 
//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0) // проверка 
{
    Console.WriteLine(BetweenSum(numberM, numberN));
}
else Console.WriteLine("Ошибка ввода");

int BetweenSum(int first, int second)
{
    if (first == second) return first; 
    if (first > second) return first + BetweenSum(first - 1, second); // уменьшаем число и складываем 
    else return first + BetweenSum (first + 1, second); // увеличиваем и складываем  first < second
}