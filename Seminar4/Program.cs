// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int num)
{
    int sum = 0;

    for(int current=1;current<=num;current++)
        sum+=current;

    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(GetSum(a));