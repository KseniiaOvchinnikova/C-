﻿// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine ("max = " + num1);
    Console.WriteLine ("min = " + num2);
}
else
{
    Console.WriteLine ("max = " + num2);
    Console.WriteLine ("min = " + num1);
}