// Напишите программу, которая принимает
// на вход число и выдает количество цифр в строке

int Count(int num)
{
    string result= num.ToString();
    return result.Length;
}
Console.WriteLine(Count(456));
Console.WriteLine(Count(45));
Console.WriteLine(Count(4569));



