
Console.WriteLine("Введи число, чтобы увидеть все целые числа между отрицательным и положительным значениями");
int N = int.Parse(Console.ReadLine());
int M = -N;

while (M < N + 1)
{
    Console.Write($"{M}, ");
    M += 1;

}
