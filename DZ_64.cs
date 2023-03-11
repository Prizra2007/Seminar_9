// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число и получите строку чисел до единицы");
int a = 1;
int b = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int a, int b)

{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a}  ";
    else return string.Empty;
}
Console.WriteLine(NumbersRec(a, b));