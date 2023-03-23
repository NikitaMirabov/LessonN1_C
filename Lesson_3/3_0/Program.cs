/* Напишите программу, которая на вход принимает координаты точки (X и Y),
но обе координаты не должны быть = 0, выдает номер четверти плоскости,
в которой эта точка. */

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("Первая четверть");
    else if (x < 0 && y > 0)
        Console.WriteLine("Вторая четверть");
    else if (x < 0 && y < 0)
        Console.WriteLine("Третья четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("Четвертая четверть");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);

