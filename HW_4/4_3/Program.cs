//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = { 1, 5, 4, 3, 2, 8, 7, 1,};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);