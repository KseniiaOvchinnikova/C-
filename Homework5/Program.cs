// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
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

int GetCountEven (int[] array)
{
    int count =0;
    for(int i=0; i<array.Length;i++)
        if(array[i] %2==0) count++;
    return count;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;

int[] array = RandomArray(n, min, max);
ShowArray(array);

Console.WriteLine("Количество четных чисел в массиве: " + GetCountEven(array));
*/

//Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
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

int GetSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i = i+2)
        sum = sum+array[i];
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(n, min, max);
ShowArray(array);

Console.WriteLine("Сумма элементов массива на нечетных позициях = " + GetSum(array));
*/

//Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i<size; i++)
        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

double GetDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }

    double result = Math.Round(max-min,2);
    return result;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomDoubleArray(n, min, max);
ShowArray(array);

Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + GetDiff(array));
*/