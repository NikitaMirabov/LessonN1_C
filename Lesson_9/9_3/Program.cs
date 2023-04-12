// 3. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.

int Sum(int N)
{
    if(N == 0) return 0;
    return Sum(N / 10) + N % 10;
}

int n = int.Parse(Console.ReadLine()!);
int res = Sum(n);

Console.Write(res);