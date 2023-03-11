// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите два целых числа и узнайте сумму всех чисел в промежетке");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int SumRange(int m, int n)
{
    if (n > m)
    {
        return n + SumRange(m, n - 1);
    }
    if (n < m)
    {
        return m + SumRange(n, m - 1);
    }
    return n;

}
Console.WriteLine(SumRange(m, n));