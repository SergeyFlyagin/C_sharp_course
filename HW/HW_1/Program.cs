//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введи первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num2 = int.Parse(Console.ReadLine());

if (num2 > num1)
{
    Console.WriteLine($"{num2} > {num1} - Второе число больше первого!");
}
else
{
    Console.WriteLine($"{num1} > {num2} - Первое число больше второго!");
}

