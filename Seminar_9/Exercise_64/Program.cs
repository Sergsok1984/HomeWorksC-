// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m}; N={n}");

string NaturalNumberRec(int m, int n)
{
    if (m == n) return Convert.ToString(m);
    else return m + ", " + NaturalNumberRec(m + 1, n);
}
Console.WriteLine(NaturalNumberRec(m, n));