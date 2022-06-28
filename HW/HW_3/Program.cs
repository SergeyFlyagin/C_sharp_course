//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;
  class Program
  {
    static void Main()
     {
       Console.Write("Введите целое число ");
       int x = int.Parse(Console.ReadLine());
       double x_2 = x % 2;
       if (x_2==0) 
          Console.WriteLine("число четное");
       else
       Console.WriteLine("Число нечетное");
      }
   }
