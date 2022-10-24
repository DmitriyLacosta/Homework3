// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.Write("Введите положительное пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

bool Palindrome(int firstDigit, int secondDigit, int fourthDigit, int fifthDigit)
{
    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}

if (N >= 10000 && N <= 99999)
{
    int firstDigit = N / 10000;
    int secondDigit = (N / 1000) % 10;
    int fourthDigit = (N / 10) % 10;
    int fifthDigit = N % 10;
    if (Palindrome(firstDigit, secondDigit, fourthDigit, fifthDigit))
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Ошибка. Введите пятизначное число!");
}
