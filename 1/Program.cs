/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void printNumbersFromNTo1(int n)
{
    if (n == 1)
    {
        Console.Write($"{n}\"");
        return;
    }
    Console.Write($"{n}, ");
    printNumbersFromNTo1(n - 1);
}

int n;
n = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {n} -> \"");

printNumbersFromNTo1(n);