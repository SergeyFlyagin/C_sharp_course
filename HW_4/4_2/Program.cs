// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}
Console.WriteLine(SumNum(7836));

//------------- 2 вариант

int Sumnums(int num)
{
    int n_sum = 0;
    for (int i = num; i != 0; i /= 10)
    {
        n_sum +== num / 10;
    }
    return n_sum;
}
Console.WriteLine(SumNum(7836));
