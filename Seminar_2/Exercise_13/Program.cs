// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int ThirdDigit(int a) 
{
int result = -1;
a = Math.Abs(a);
    if (a < 100) 
    {
        Console.Write("Третьей цифры нет: ");
    } 
    else 
    {
        while (a > 999) 
        a /= 10;        
        result = a % 10;
    }
return result;
}
Console.WriteLine(ThirdDigit(Convert.ToInt32(Console.ReadLine())));