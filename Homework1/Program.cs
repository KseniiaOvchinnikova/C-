// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
Console.WriteLine("max = " + num1);

if(num2>max)
{
    Console.WriteLine("max = " + num2);
}

if(num3>max)
{
    Console.WriteLine("max = " + num3);
}
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine(num + " - Четное");
}
else
{
    Console.WriteLine(num + " - Нечетное");
}
*/

//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;

while(index <= N)
{
if (index % 2 == 0 )
{
Console.WriteLine(index);
}
index++;
}
*/