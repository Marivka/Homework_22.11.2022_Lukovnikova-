// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("будний");
}

if (number == 2)
{
    Console.WriteLine("будний");
}

if (number == 3)
{
    Console.WriteLine("будний");
}

if (number == 4)
{
    Console.WriteLine("будний");
}

if (number == 5)
{
    Console.WriteLine("будний");
}

if (number == 6)
{
    Console.WriteLine("выходной");
}

if (number == 7)
{
    Console.WriteLine("выходной");
}

if (number < 1 || number > 8)
{
    Console.WriteLine("Неправильное значение");
}