// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string desired = Convert.ToString(number);

if (desired.Length >2)
{
    Console.WriteLine($"Третья цифра {desired[2]}");
}
else{
    Console.WriteLine($"Третьей цифры нет");
}
