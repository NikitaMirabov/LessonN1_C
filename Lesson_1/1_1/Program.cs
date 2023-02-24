string s1 = Console.ReadLine()!;
int num1 = int.Parse(s1);
string s2 = Console.ReadLine()!;
int num2 = int.Parse(s2);

if (num1 == num2*num2)
{
    Console.Write("Yes,");
    Console.Write(num1);
    Console.Write("=");
     Console.Write(num2);
      Console.Write("*");
      Console.Write(num2);
}
else
{
   Console.Write("No,");
    Console.Write(num1);
    Console.Write(" not = ");
     Console.Write(num2);
      Console.Write("*");
      Console.Write(num2);
}