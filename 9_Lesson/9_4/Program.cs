// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int ValuesNum(int A, int B)
{
    if (B == 0) return 1;
    return ValuesNum(A, B - 1) * A;
}
Console.Write(ValuesNum(0,0));

