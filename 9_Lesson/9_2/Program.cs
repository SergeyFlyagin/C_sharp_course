// Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void ValuesSet(int M, int N)
{
    if (N < M) return;
    ValuesSet(M, N-1);
    Console.Write($"{N}, ");
}
ValuesSet(1,5);