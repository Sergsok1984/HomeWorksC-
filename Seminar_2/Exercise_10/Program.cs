﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int SecondDigit(int a) 
{
    a = Math.Abs(a);
    return a / 10 % 10;
}
Console.WriteLine(SecondDigit(Convert.ToInt32(Console.ReadLine())));