//string num_str = Console.ReadLine();
//int num = int.Parse(num_str);

Console.WriteLine("Введи первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
int num2 = int.Parse(Console.ReadLine());

if (num2 == num1 * num1)
{
    Console.WriteLine($"{num1}^2 = {num1 * num1} - Да, второе число является квадратом первого!");
}
else
{
    Console.WriteLine($"{num1}^2 = {num1 * num1} - Нет, второе число не является квадратом первого!");
}



