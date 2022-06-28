// Программа вычисления модуля числа

Console.WriteLine("Введи число");
int x = int.Parse(Console.ReadLine());
if (x < 0) ;
{
    x = -x;
}
Console.WriteLine($"{x}");
