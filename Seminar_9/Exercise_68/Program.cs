﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m={m}; n={n}");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m != 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

AkkermanFunction(m,n);