// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

int SumNum(int num)
{
    int nsum = 0;
    for (int i = num; num != 0; num /= 10)
        nsum += num % 10;

    return nsum;
}
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);