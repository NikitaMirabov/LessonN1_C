//  Эта программа принимает число и выдаёт, является ли число чётным.

Console.WriteLine("Привет, впиши число, а я проверю, четное ли оно");

string s1 = Console.ReadLine()!;
double num = double.Parse(s1);

if (num % 2 == 0)
{
   
    Console.Write(num);
    Console.Write(" - Четное!) ");

}

else
{

    Console.Write(num);
    Console.Write(" - Не делится на 2 без остатка!) ");

}