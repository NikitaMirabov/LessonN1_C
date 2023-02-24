//  Эта программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Привет! Введи 2 числа по очереди, а я проверю и проставлю >, < или =");

string s1 = Console.ReadLine()!;
double num1 = double.Parse(s1);
string s2 = Console.ReadLine()!;
double num2 = double.Parse(s2);

if (num1 == num2)
{
   
    Console.WriteLine("Числа равны!");
    Console.Write(num1);
    Console.Write(" = ");
   
    Console.Write(num2);
}

else if (num1 > num2)
{

    Console.WriteLine("Первое число больше второго!");
    Console.Write(num1);
    Console.Write(" > ");
    Console.Write(num2);
    
}

else
{

   Console.WriteLine("Второе число больше первого!");
    Console.Write(num1);
    Console.Write(" < ");
    Console.Write(num2);

}





