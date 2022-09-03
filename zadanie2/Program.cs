// Задача 27
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел = {GetSumNumber(number)}");

int GetSumNumber(int number)
{
    int sum;
    sum = number % 10;
    if (number >= 10)
    {
        sum += GetSumNumber(number / 10);
    }
    return sum;
}