/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int akkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return akkermanFunction(m - 1, 1);
    return akkermanFunction(m - 1, akkermanFunction(m, n - 1));
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int result = akkermanFunction(m, n);

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {result}");