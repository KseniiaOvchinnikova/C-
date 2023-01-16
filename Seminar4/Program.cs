// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
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
*/

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Numbers(int n)
{
    int count = 0;
    while(n != 0)
    {
        n = n / 10;
        count += 1;
    }
    return count;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = Numbers(a);
Console.WriteLine(Numbers(a)); 
*/

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int GetProd(int num)
{
    int prod = 0;

    for(int current = 1; current <= num; current++)
        prod = current * (current + 1);

    return prod;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetProd(a);
Console.WriteLine(GetProd(a)); 
*/

// Массивы.

int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(n, min, max);
ShowArray(newArray);