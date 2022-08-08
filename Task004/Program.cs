﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8 

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >=100 || a <= 999)
{
    Console.WriteLine($"Последняя цифра числа {a} = {a % 10}");
}
else
{
    Console.WriteLine("Неверно введённое число");
}