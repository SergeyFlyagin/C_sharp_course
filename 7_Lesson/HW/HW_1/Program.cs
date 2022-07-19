// Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] FillArray(int row, int column, double from, double to)
{
    double[,] matr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {

            matr[i, j] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
        }
    }
    return matr;
}
double[,] matrix = FillArray(3, 4, 2, 21);
PrintArray(matrix);
Console.WriteLine();
