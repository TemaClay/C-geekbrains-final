/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sumFromMToN(int m, int n)
{
    if (m == n)
        return n;
    return m + sumFromMToN(m + 1, n);
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int result = sumFromMToN(m, n);

Console.WriteLine($"M = {m}; N = {n} -> {result}");