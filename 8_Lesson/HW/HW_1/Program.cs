// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 3 10 7 3
// 1 5 9 3
// 8 4 7 0
// 7 1 9 3
// В итоге получается вот такой массив:

// 10 7 3 3
// 9 5 3 1
// 8 7 4 0
// 9 7 3 1

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
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
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void InMaxToMin(int[,] arr)
{
    int rowS = arr.GetLength(0);
    int columnS = arr.GetLength(1);

    for (int i = 0; i < rowS; i++)
    {
        for (int j = 0; j < columnS; j++)
        {
            for (int k = 0; k < columnS - j - 1; k++)
                if (arr[i, k] < arr[i, k + 1])
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
        }
    }
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);

InMaxToMin(arr_1);
Print(arr_1);


