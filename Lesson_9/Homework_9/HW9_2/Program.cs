// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

void FromTo(int M, int N, int Sum)
{
    if (M < N)
    {
        Console.Write($"Сумма натуральных чисел в промежутке: {Sum} ");
        return;
    }
    Sum = Sum + N++;
    FromTo(M, N, Sum);
}

Console.WriteLine("От какого числа идем?");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("До какого числа идем?");
int m = int.Parse(Console.ReadLine()!);

FromTo(m, n, 0);