/* Задача 2: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
- 645 -> 5
- 78 -> третьей цифры нет
- 32679 -> 6                                                      */

/* Я не доделал, чтобы многозначное число резало себя до трехзначного! */

Console.WriteLine("Введите положительное число, я выведу 3-ю цифру");

int TakeNum(int num)
{
    if (num < 100) 
    { 
        Console.WriteLine("Третьей цифры нет!");
        return -1;
    
    }    

    while (num > 999)
    {

        num= num /= 10;

    }
    return num % 10;
    
}


int result = TakeNum(int.Parse(Console.ReadLine()!));
if ( result == -1) return;
else Console.WriteLine("Третья цифра: " + result);
 





