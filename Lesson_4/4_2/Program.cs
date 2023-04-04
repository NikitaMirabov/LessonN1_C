// Напишите программу которая приниает но вход число N и выдаетпроизведение чисел от 1 до N

int Num(int num)
{
    int all = 1;
    for (int i = 1; i <= num; i++)
        all *= i;

    return all;
}

int A = int.Parse(Console.ReadLine()!);
int result = Num(A);
Console.WriteLine(result);

