﻿// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

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

int[] MultiMas(int[] arr)
{
    int size = arr.Length;
    int[] newMass = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2; i++)
    {
        newMass[i] = arr[i] * arr[size - 1 - i];
    }
    if (size % 2 == 1)
    {
        newMass[newMass.Length - 1] = arr[arr.Length/2];
    }
    return newMass;

}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int[] newNewmass = MultiMas(mass);
Print(newNewmass);

