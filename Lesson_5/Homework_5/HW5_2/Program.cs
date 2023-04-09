/*  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int NumsSum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i+=2)
    {
            count = count + arr[i];
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int result = NumsSum(mass);
Console.WriteLine("Сумма чисел на нечетных позициях = "+ result);


