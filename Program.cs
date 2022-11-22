/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

*/

// Вводим с терминала числа a  b c
Console.WriteLine("Введите число a:");
string input_a = Console.ReadLine();
int a = Convert.ToInt32(input_a);
Console.WriteLine("Введите число b:");
string input_b = Console.ReadLine();
int b = Convert.ToInt32(input_b);
Console.WriteLine("Введите число c:");
string input_c = Console.ReadLine();
int c = Convert.ToInt32(input_c);

if (a > b)
{
    if (a > c)
    {
        System.Console.WriteLine("max = " + a);
    }
    else if (c > a)
    {
        System.Console.WriteLine("max = " + c);
    }
    else
    {
        System.Console.WriteLine("a и c - равны, max =  " + c);
    }

}
else if (b > a)
{
    if (b > c)
    {
        System.Console.WriteLine("max = " + b);
    }
    else if (c > b)
    {
        System.Console.WriteLine("max = " + c);
    }
    else
    {
        System.Console.WriteLine("b и c - равны, max = " + c);
    }

}
else
{
    if (a > c)
    {
        System.Console.WriteLine("a и b - равны, max = " + a);
    }
    else if (c > a)
    {
        System.Console.WriteLine("a и b - равны, max = " + c);
    }
    else
    {
        System.Console.WriteLine("Числа одинаковые");
    }

}


