// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.

double Num(int a, int b)
{
    double num1 = 1;
    int num2 = Math.Abs(b);

    for (int i = 1; i <= num2; i++)
    {
        if (b > 0)
            num1*= a;
        else    
            num1 /= a;

    }
    return num1;
}
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Num(A, B));