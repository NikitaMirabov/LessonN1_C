﻿/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76 */

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]};  ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    return arr;
}

void DifMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if(n_max < arr[i])
            n_max = arr[i];

        else if(n_min > arr[i])
            n_min = arr[i];    
    }
    Console.Write($"Max = {n_max};  min = {n_min}. ");
    Console.WriteLine($"Difference {n_max}-({n_min}) = {Math.Round(n_max - n_min, 2)}");

}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
DifMaxMin(mass);

