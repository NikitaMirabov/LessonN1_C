/* Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. */

int Num(int num)
{
    
    Console.WriteLine(num);
    int num1 = num / 100;
    int num2 = num % 10;
    Console.Write(num1);
    Console.Write(num2);
    return num;

}

int result = Num(new Random().Next(100, 1000));