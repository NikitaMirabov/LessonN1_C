/* Задача 3: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
- 6 -> да
- 7 -> да
- 1 -> нет */

void TakeNum(int num)
{
   
    if (num > 0 & num < 6) 
    { 
         
        Console.WriteLine(num + " - Рабочий!"); 
    
    }    
    else if (num > 5 & num < 8) 
    { 
         
        Console.WriteLine(num + " - Выходной!"); 
    
    }    
    else
    {

        Console.WriteLine(num + "?! - Такого дня нет!");

    }

}

TakeNum(int.Parse(Console.ReadLine()!));
 