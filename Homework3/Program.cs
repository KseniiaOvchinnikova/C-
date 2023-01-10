// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double GetDistance(double x1, double y1, double z1,
                    double x2, double y2, double z2)
    {
        double result = Math.Sqrt (Math.Pow (x2-x1, 2)+ Math.Pow (y2-y1, 2) + Math.Pow (z2-z1, 2));
        return result;
    }

    Console.WriteLine("Введите координаты первой точки: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    double y1 = Convert.ToDouble(Console.ReadLine());
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    double y2 = Convert.ToDouble(Console.ReadLine());
    double z2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Расстояние между двумя точками равно " + GetDistance(x1,y1,z2,x2,y2,z2));
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int n)
{
    int num = 1;
    Console.Write("Кубы чисел: ");
    while (num < n + 1)
    {
        Console.Write(num*num*num + " ");
        num = num+1;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/
