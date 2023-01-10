// Задача 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*

void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetQuadrant(int x, int y)
{
    int quad = -1;
    if(x>0 && y>0) quad = 1;
    else if (x<0 && y >0) quad =2;
    else if (x<0 && y<0) quad = 3;
    else if (x>0 && y <0) quad = 4;
    return quad;
}

Console.WriteLine("Введите координаты точки x и y: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (GetQuadrant(x,y) == -1) Console.WriteLine("Некорректный ввод!");
else Console.WriteLine("Номер четверти: " + GetQuadrant(x,y));
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
/*
void Quadrat (int n)
{
    int num = 1;
    Console.Write("Квадраты чисел: ");
    while (num < n + 1)
    {
        Console.Write(num*num + " ");
        num = num+1;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Quadrat(n);
*/

// Задача 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


