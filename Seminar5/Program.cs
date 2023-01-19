/*
int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue);

    return array;
}

int[] CreateArray (int size)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetSumOfNegative (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i]<0)
            sum += array[i];

    return sum;
}


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.


Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(n, min, max);
ShowArray(newArray);

int result = GetSumOfNegative(newArray);
Console.WriteLine("Сумма отрицательных элементов массива равна " + result);

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] RandomArray(int size, int minValue, int maxValue)
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

int[] array = RandomArray(n, min, max);
Console.WriteLine($"Массив: "); 
ShowArray(array);

int[] GetReverse(int[]massiv)
{
    for (int i = 0; i < array.Length; i++)
        massiv[i] = massiv[i]*-1;
    return massiv;
}

int[] result = GetReverse(array);
Console.WriteLine($"Вариант нового массива: "); 
ShowArray(result);

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

bool Number (int[] array, int num)
{
    for (int i = 0; i <array.Length; i++)
    {
    if (array[i] == num) return true;
    }
    return false;
}

Console.Write("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number(newArray, num));



//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

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

int GetCountFind(int[]array, int min_num, int max_num)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]>= min_num && array[i]<=max_num) count++;
    }
return count;
}

Console.Write("Введите минимальный предел поиска: ");
int min_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный предел поиска: ");
int max_num = Convert.ToInt32(Console.ReadLine());

int result = GetCountFind(newArray, min_num, max_num);
Console.WriteLine("Количество элементов в заданном пределе:" + result);
*/