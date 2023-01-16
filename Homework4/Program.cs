//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponent (int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int resultat = Exponent(a,b);
Console.Write("Отыет: " + resultat);
*/

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSum(int num)
{
    int sum = 0;
    while(num !=0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine("Сумма цифр этого сисла равна: " + GetSum(a));
*/

//Задача 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] RandomArray (int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next();

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

int[] newArray = RandomArray(n);
ShowArray(newArray);
*/