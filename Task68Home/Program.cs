//Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

// А(0,m) = m + 1
// A(n+1,0) = A(n,1)
// A(n+1,m+1) = A(n,A(n+1,m))

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    Console.WriteLine(Akkerman(numberM, numberN));
}
else Console.WriteLine("Ошибка ввода");

int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numN == 0) return Akkerman(numM - 1, 1);
    return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}