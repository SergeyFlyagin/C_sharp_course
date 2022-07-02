//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


void ThirdNumber(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine($"Третья цифра отсутствует");
    }
    while (num > 1000)
    {
        num = num / 10;
        Console.WriteLine(num % 10);
    }
}
ThirdNumber(int.Parse(Console.ReadLine()));