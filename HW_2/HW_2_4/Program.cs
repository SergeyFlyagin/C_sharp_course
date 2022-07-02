//Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"{num} -> Да - это выходной");
    }
   
    else
        Console.WriteLine($"{num} -> Нет - это будний день");
}
Weekend(6);
Weekend(7);
Weekend(3);
