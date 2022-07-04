//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число!");
int number = int.Parse(Console.ReadLine());
int num = number;
int Temp = 0;
while (number > 0)
{
    Temp = Temp * 10 + number % 10; 
    number /= 10;
}
if(num == Temp)
{
   Console.WriteLine($"{num} -> Введенное число, является палиндромом!"); 
} 
else
Console.WriteLine($"{num} -> Введенное число, не является палиндромом!");
