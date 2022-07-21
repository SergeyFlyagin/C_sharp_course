// Задайте значения M и N.
// Напишите программу, которая выведет 
// все четные натуральные числа в промежутке  
// от M до N с помощью рекурсии 

void EvenElements(int M, int N)
{
    if (N < M) return;
    EvenElements(M, N - 1);
    if(N % 2 == 0)
    Console.Write($"{N} ");
}
EvenElements(4, 8);