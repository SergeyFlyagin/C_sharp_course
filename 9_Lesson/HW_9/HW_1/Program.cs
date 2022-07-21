// Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в
//  промежутке от M до N.

int SumElements(int M, int N)
{
    if (N < M) return 0;
    return SumElements(M, N - 1) + N;
}
Console.Write(SumElements(4, 8));