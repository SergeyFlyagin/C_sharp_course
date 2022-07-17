// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.

void Line(double b1, double b2, double k1, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение в точке: ({x}; {y})");
}

Line(9, -3, 4, -6);


