// Напишите программу которая на вход принимает трехзначное число
// и на выходе показывает последнюю цифру

int TakeNum(int num)
{
    return num % 10;
}

Console.WriteLine(TakeNum(678));
Console.WriteLine(TakeNum(678222));