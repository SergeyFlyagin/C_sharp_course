// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 50);
    }
    return arr;
}

void SumNum(int[] arr)
{
    int s_max = 0;
    int s_min = 50;
    int temp;
    for (int i = 0; i < arr.Length; i++)
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
    temp = s_max - s_min;
    Console.WriteLine($"{s_max} - {s_min} = {temp}");
}
int[] arr_1 = MassNums(10);
Print(arr_1);
SumNum(arr_1);


