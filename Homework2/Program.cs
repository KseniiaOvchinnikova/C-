// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int NumberOfThreeDigit(int number)
{
    if(number <100 || number>999)
    {
        Console.WriteLine($"The number{number} is not Three-digit");
        return -1;
    }
    return number / 10%10;
}
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The second number is {NumberOfThreeDigit(number)}");
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumber(int number)
{
    int sot = number/100;
    if(sot ==0)
    {
        return-1;
    }
    int remainder = 1;
    while(sot>0)
    {
        sot/=10;
        remainder*=10;
    }
    return number % remainder / (remainder / 10);

}
Console.Write("Enter a three-digit number: ");
int number=Convert.ToInt32(Console.ReadLine());

if(ThirdNumber(number)==-1)
{
    Console.WriteLine($"The number {number} is not three-digits");
}
else
{
Console.WriteLine($"The number {ThirdNumber(number)} is third number of three-digit number");
}
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool isHoliday(int day)
{
    if(day ==6 || day ==7)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

Console.Write("Enter the number day of the week: ");
int day=Convert.ToInt32(Console.ReadLine());

if(isHoliday(day))
{
    Console.Write("Holiday");
}
else
{
    Console.Write("Workday");
}

