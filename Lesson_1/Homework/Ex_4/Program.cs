// Эта программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Привет, впиши целое число N, а я перечислю все четные числа от 1 до N включительно");

string s = Console.ReadLine()!;
int a = int.Parse(s);
int b = 2;

if (a < 2)
{

    Console.Write(" Укажите число больше 1, пожалуйста!");

}

while (b <= a)
{
    Console.Write(b);
    Console.Write("; ");
    b=b+2;
}

