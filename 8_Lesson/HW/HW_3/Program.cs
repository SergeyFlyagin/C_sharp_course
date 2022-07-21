// Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

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

int[,] MatrixFactor(int[,] arr_first, int[,] arr_second)
{
    int rowS = arr_first.GetLength(0);
    int columnS = arr_first.GetLength(1);
    int[,] newmatrix = new int[rowS, columnS];

    if (rowS != arr_second.GetLength(0) || columnS != arr_second.GetLength(1)) return newmatrix;
    
    for (int i = 0; i < rowS; i++)       
        for (int j = 0; j < columnS; j++)
            newmatrix[i, j] = arr_first[i, j] * arr_second[i, j];            
    return newmatrix;
}


Console.Write("Введите количество строк матрицы 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк матрицы 2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1, 0, 5);
Print(arr_1);
int[,] arr_2 = MassNums(row_2, column_2, 0, 5);
Print(arr_2);

int[,] res_matrix = MatrixFactor(arr_1, arr_2);
Print(res_matrix);
