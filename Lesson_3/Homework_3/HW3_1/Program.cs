/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число, а я проверю является ли оно палиндромом.");

int num = int.Parse(Console.ReadLine()!);
void CheckNum(int num)
{
    
    int num1 = num / 10000;
    int num5 = num % 10;
    int num2 = num / 1000;
    int num4 = num % 100;

    if (num1 == num5 || num2 == num4) 
        Console.Write("Палиндром!");

    else Console.Write("Не Палиндром!");
    
}
 
CheckNum(num);