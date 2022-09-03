// Задача 25
//  Напишите цикл, который принимает на вход два числа (A и B)
//   и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"{numberA} в степени {numberB} = {Math.Pow(numberA, numberB)}");