/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

// Вводим с терминала числа a и b
Console.WriteLine("Введите число a:");
string input_a = Console.ReadLine();
int a = Convert.ToInt32(input_a);
Console.WriteLine("Введите число b:");
string input_b = Console.ReadLine();
int b = Convert.ToInt32(input_b);

if (a > b)
{
    System.Console.WriteLine("max = " + a);
}
else if (b > a)
{
    System.Console.WriteLine("max = " + b);
}
else
{
    System.Console.WriteLine("Числа одинаковые");
}


