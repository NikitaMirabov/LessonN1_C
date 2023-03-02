/* Программа проверяет кратно ли введеное число одновременно 7 и 23 */

int a = int.Parse(Console.ReadLine()!);

void Div(int a)
{

    if (a % 7 == 0 & a % 23 ==0) Console.WriteLine("Кратно");
    else Console.WriteLine("Не кратно");

}

Div(a);