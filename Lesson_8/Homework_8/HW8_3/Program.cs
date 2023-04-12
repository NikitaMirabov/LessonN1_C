// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int[,] MatrixProduct(int[,] arr_first, int[,] arr_second)
{
    int row1 = arr_first.GetLength(0);
    int column1 = arr_first.GetLength(1);

    int row2 = arr_second.GetLength(0);
    int column2 = arr_second.GetLength(1);

    int[,] pr_matrix = new int[row1, column1];

    if(column1 != row2) return pr_matrix;
    else if (column1 == row2)
        pr_matrix = new int[row1, column2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int p = 0; p < column1; p++)
                pr_matrix[i, j] += arr_first[i, p] * arr_second[p, j];
        }    
    }
    return pr_matrix;
}
Console.WriteLine("Enter number of rows for 1 mat");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number of columns for 1 mat");
int column_num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number of rows for 2 mat");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number of columns for 2 mat");
int column_num2 = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row_num1, column_num1, start, stop);
Print(arr_1);

int[,] arr_2 = MassNums(row_num2, column_num2, start, stop);
Print(arr_2);

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);