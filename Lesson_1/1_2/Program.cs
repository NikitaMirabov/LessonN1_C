// Программа пишет название дня недели в зависимости от дня по счету, который мы вводим
Console.WriteLine("Enter a number from 1 to 7, and I'll name the day of the week.");
string s = Console.ReadLine()!;
int num = int.Parse(s);

if (num == 1)
{
    Console.Write("The first day of the week is Monday!");
}
else if (num == 2)
{
    Console.Write("The second day of the week is Tuesday!");
}
else if (num == 3)
{
    Console.Write("The third day of the week is Wednesday!");
}
else if (num == 4)
{
    Console.Write("The fourth day of the week is Thursday!");
}
else if (num == 5)
{
    Console.Write("The fifth day of the week is Friday!");
}
else if (num == 6)
{
    Console.Write("The sixth day of the week is Saturday!");
}
else if (num == 7)
{
    Console.Write("The seventh day of the week is Sunday!");
}

else
{
 Console.WriteLine("I told you to choose a number from 1 to 7 (integer)!");   
}

