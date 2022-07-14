// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

void SumNum(double[] arr)
{
    double s_max = arr[0];
    double s_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {

        if (arr[i] > s_max)
        {
            s_max = arr[i];
        }
        else if (arr[i] < s_min)
        {
            s_min = arr[i];
        }

    }
    Console.Write ($"Max {s_max}, Min {s_min}. ");
    Console.WriteLine($" Разница {s_max} - ({s_min}) = {Math.Round(s_max - s_min, 2)}");
}
   
double[] arr_1 = MassNums(10);
Print(arr_1);
SumNum(arr_1);


