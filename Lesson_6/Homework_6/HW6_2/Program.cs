/* Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем. */

void Interselection(double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2;
    if (k_sub != 0)
    {
        double x = (b2-b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Interselection point({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("They are an infinite number of interselection points");
    else
        Console.WriteLine("They is no interselection points");
}


double k_1 = double.Parse(Console.ReadLine()!);
double b_1 = double.Parse(Console.ReadLine()!);
double k_2 = double.Parse(Console.ReadLine()!);
double b_2 = double.Parse(Console.ReadLine()!);

Interselection(k_1, b_1, k_2, b_2);