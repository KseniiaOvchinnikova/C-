// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumberOfThreeDigit(int number)
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
Console.WriteLine($"The second number is {SecondNumberOfThreeDigit(number)}");