﻿Console.Write("Введите А = ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите B = ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите С = ");
int number3 = int.Parse(Console.ReadLine());

if(number1 > number2 || number1 > number3 )
{
    Console.WriteLine($"max = {number1}");
    return;
}

if(number2 > number1 || number2 > number3 )
{
    Console.WriteLine($"max = {number2}");
    return;
}

if(number3 > number1 || number3 > number2 )
{
    Console.WriteLine($"max = {number3}");
    return;
}