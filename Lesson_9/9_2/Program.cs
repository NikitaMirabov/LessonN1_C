// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void FromTo(int N, int M)
{
    if(N + 1 == M) return;
    FromTo(N-1, M);
    Console.Write($"{N} ");
}

int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
FromTo(n, m);