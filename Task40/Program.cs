// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(number1, number2, number3);
Console.WriteLine(result ? "Такой треугольник существует" : "Такой треугольник не существует");

bool IsitPositiveCheck(int num1, int num2, int num3) // проверка на положительность числа 
{ 
    return num1 > 0 && num2 > 0 && num3 > 0;
}

bool IsExistTriangle(int num1, int num2, int num3)
{
    int sum1 = num1 + num2;
    int sum2 = num1 + num3;
    int sum3 = num2 + num3;

    if (sum1 > num3 && sum2 > num2 && sum3 > num1)
    return true;

    else 
    return false;
    // return sum1 > num3 && sum2 > num2 && sum3 > num1 можно сразу так вернуть без иф и элс
}

if (IsitPositiveCheck(number1, number2, number3))
{
    bool resCheck = IsExistTriangle(number1, number2, number3);
    Console.WriteLine(resCheck ? "Да" : "Нет");
}
else Console.WriteLine("Ошибка ввода числа");