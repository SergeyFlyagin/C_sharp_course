// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int MultNum(int numA, int numB)
{
    int count = 1;
    for (int i = 1; i <= numB; i++) 
    count*=numA;
   
    return count;
}

Console.WriteLine(MultNum(3,5));
Console.WriteLine(MultNum(2,4));
