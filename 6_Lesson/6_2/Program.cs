// 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Binary(int n)
{
    string Dec = "";
    while (n > 0)
    {
        Dec = n % 2 + Dec;
        n /= 2;
    }
    Console.WriteLine($"{Dec} ");
}
Binary(2);