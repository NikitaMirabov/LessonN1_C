//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Check(int num)
{
    int count = 0;

    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int b = int.Parse(Console.ReadLine()!);
        if (b > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел вы хотите ввести?");
int a = int.Parse(Console.ReadLine()!);
int result = Check(a);
Console.WriteLine($"Кол-во чисел больше 0: {result}");
