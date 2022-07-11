// // 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

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
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void MassNum(int[] arr, int num)
{
    string num_1 = "Нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            num_1 = "Да";
            break;
        }
    }
    Console.WriteLine($"{num}, {num_1} ");
}
int[] arr_1 = MassNums(12);
Print(arr_1);
MassNum(arr_1, 4);

