//string num_str = Console.ReadLine();
//int num = int.Parse(num_str);

Console.WriteLine("Введите номер дня недели.");
int day = int.Parse(Console.ReadLine());


if (day == 1)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Среда");
}
else if (day == 4)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Суббота");
}
else if(day == 7)
{
    Console.WriteLine("Введенному номеру соответствует день недели - Воскресенье");
}


