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