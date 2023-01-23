// задача1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i<j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    } 
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(n, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
*/
// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Tringle(int a, int b, int c)
{
    if(a+b>c && a+c>b && b+c>a) return true;
    else return false;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = Tringle(a,b,c);
Console.WriteLine("Ответ: " + result);


// задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] Fibonachchi(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i<size; i++)
        array[i] = array[i-2] + array[i-1];

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
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonachchi(n,a,b);
ShowArray(result);
*/

// Задача 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue);

    return array;
}

int[] CopyArray (int[] array, int size)
{
    int[]newarray = new int[size];
    for(int i = 0; i < array.Length; i++)
        newarray[i] = array[i];
    return newarray;
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
int[] result = CopyArray(newArray,n);
ShowArray(result);
*/
