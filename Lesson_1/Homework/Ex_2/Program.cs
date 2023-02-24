// Эта программа принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Привет! Введи 3 числа по очереди, а я назову наибольшее");

string s1 = Console.ReadLine()!;
double num1 = double.Parse(s1);

string s2 = Console.ReadLine()!;
double num2 = double.Parse(s2);

string s3 = Console.ReadLine()!;
double num3 = double.Parse(s3);

double max = num1;

if (num1*2 == num2 + num3)
{
   
    Console.WriteLine("Все числа равны!");
    Console.Write(num1);
    Console.Write(" = ");
    Console.Write(num2);
    Console.Write(" = ");
    Console.Write(num3);

}

else if (num2 > max) 
{ 
    max = num2;
    Console.Write(max);
    Console.Write(" - самое большое число!");
    
} 

else if (num3 > max)
{ 
    max = num3;
    Console.Write(max);
    Console.Write(" - самое большое число!");
    
} 
   


