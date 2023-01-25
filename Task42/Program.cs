// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string res = ConvertDocToBin(2);
Console.WriteLine(res);

string ConvertDocToBin(int num)
{
    string result = string.Empty; // тоже самое что прировнять нулю, пустая строка 
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int convertDecimaToBinary = ConvertDecimaToBinary(number);
Console.WriteLine(convertDecimaToBinary);

int ConvertDecimaToBinary(int num)
{
    int result = 0;
    int ostatok = 0; 
    int multiplayer = 1;

    while (num !=0)
    {
        ostatok = num % 2;
        result = result + ostatok * multiplayer;
        num = num / 2;
        multiplayer *=10;
    }
    return result;
}