 /* Напишите программу, которая на входе принимает трехзначное число, 
 а на выходе показывает последнюю цифру этого числа */

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;

}

/* 
int num = new Random().Next(100, 1000);
 */

int result = TakeNum(new Random().Next(100, 1000));

Console.WriteLine(result);