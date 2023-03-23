/* Программа принимает на вход два числа и выводит, является ли второе число кратным первому, 
если второе чило не кратно первому, она выводит остаток от деления. */

void Div(int num1, int num2)
{

    if (num1 % num2 == 0) Console.WriteLine("Кратно");
    else Console.WriteLine("Не кратно, остаток " + num1 % num2);

}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

Div(a, b);

