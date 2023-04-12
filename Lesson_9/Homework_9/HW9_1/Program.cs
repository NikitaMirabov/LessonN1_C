// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void FromTo(int M, int N)
{
    if (M == N ) return;
    if (M % 2 == 0 )
        Console.Write($"{M}; ");
    FromTo(M+1, N);
}

Console.WriteLine("От какого числа идем?");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("До какого числа идем?");
int n = int.Parse(Console.ReadLine()!);

FromTo(m, n + 1);