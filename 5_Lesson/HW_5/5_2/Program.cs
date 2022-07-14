// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

int SumMaxMin(int[] arr)
{
    int SumNumber = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        SumNumber += arr[i];

    }
    return SumNumber;
}

int[] arr_1 = MassNums(6, 1, 13);
Print(arr_1);
Console.WriteLine(SumMaxMin(arr_1));
