// 2. Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.


void NumRand()
{
    int Num = new Random().Next(100, 999);
    Console.WriteLine($"{Num} ->{Num / 100 * 10 + Num % 10}");
}

NumRand();