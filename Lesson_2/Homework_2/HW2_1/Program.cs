/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */
Console.WriteLine("Привет! Введи трехзначное число.");
int num = int.Parse(Console.ReadLine()!);

if (num < 100 || num >= 1000)
{

    Console.WriteLine("Нет, нужно трехзначное число, введи его на следующем шаге");
    int num3 = int.Parse(Console.ReadLine()!);

    if (num3 < 100 || num3 >= 1000) 
    { 
        Console.WriteLine("Опять число не трехзначное! Перезапусти программу."); 
        return;
    }    
    int num4 = num3/10%10;
    Console.WriteLine("Ответ: " + num4);

}
else
{

    int num2 = num/10%10;
    Console.WriteLine("Ответ: " + num2);

}

