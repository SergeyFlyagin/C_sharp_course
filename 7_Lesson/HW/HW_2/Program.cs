// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string FindElement(int[,] arr, int a, int b)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (a > row || a <= 0 || b > column || b <= 0)
        return $"{a} {b} -> Не находится в массиве";
    return $"arr[{a}, {b}] = {arr[a - 1, b - 1]} -> Находится в массиве";
}

Console.Write("Enter the line position: ");
int one = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int two = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(3, 4, 1, 11);
Print(arr_1);

Console.WriteLine(FindElement(arr_1, one, two));