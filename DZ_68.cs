// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите по порядку два целых неотрицательных числа и узнайте сумму всех чисел в промежетке");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m, n);

}
Console.WriteLine(Akkerman(m, n));