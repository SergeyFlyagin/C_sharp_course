//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введи первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи третье число");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} - Первое число больше!");
}
else
{
    if(num2>num3)
    {
    Console.WriteLine($"{num2} - Второе число больше!");
    }
    else
    {
       Console.WriteLine($"{num3} - Третье число больше!"); 
    }
}