// 4. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

int Pow(int A, int B)
{
    if(B == 0) return 1;
    return A* Pow(A, B-1);
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

int res = Pow(a, b);
Console.Write(res);
