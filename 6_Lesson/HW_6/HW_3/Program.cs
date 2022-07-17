// Напишите программу, которая будет создавать копию
//  заданного двумерного массива с помощью поэлементного копирования.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void CopyArray(int[,] matr)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    int[,] new_matr = new int[row, column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            new_matr[i, j] = matr[i, j];
        }
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
int[,] new_matrix = new int[3, 4];
CopyArray(new_matrix);