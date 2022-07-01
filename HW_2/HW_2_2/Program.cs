// 2. Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.


int MaxNumber(int num)
{
    if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else
        return num / 10;
}
int SecondNum = new Random().Next(10, 99);
MaxNumber(SecondNum);
Console.WriteLine(SecondNum);
Console.WriteLine(MaxNumber(SecondNum));
