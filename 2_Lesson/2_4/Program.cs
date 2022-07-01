// 4. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.


void OneOfNum(int num_1)
{
    if (num_1 % 7 == 0 && num_1 % 23 == 0)
    {
        Console.WriteLine($"{num_1}-> ДА");
    }
    else
    {
        Console.WriteLine($"{num_1}-> Нет");
    }
}
OneOfNum(16);
OneOfNum(161);
