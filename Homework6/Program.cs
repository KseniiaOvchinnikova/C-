//Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int PositivCount(int size)
{
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите количество чисел для проверки {i+1}: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Введите числа: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество положительных чисел равно: " + PositivCount(size));
*/

//Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double CrossPointX (double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    return x;
}

double CrossPointY (double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите первую точку для прямой 1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую точку для прямой 1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первую точку для прямой 2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую точку для прямой 2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = CrossPointX(k1,b1,k2,b2);
double y = CrossPointY(k1,b1,x);
Console.WriteLine($"Координаты точки пересечения двух прямых: ({x};{y})");