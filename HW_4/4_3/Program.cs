//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Print(int[] arr)
{
    int size=arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] Mass()
{
    int size = 8;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int[]arr_1=Mass();
Print(arr_1);
int[]arr_2=Mass();
Print(arr_2);
