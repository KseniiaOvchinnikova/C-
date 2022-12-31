// Задача 1. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)

    {
        int sot = number / 100;
        int ed = number % 10;

        int result = sot * 10 + ed;
        return result;
    }

int randNumber = new Random().Next(100,1000);
Console.WriteLine("Current random three-digit number is " + randNumber);

int newNumber = CutNumber(randNumber);
Console.WriteLine("New version number is " + newNumber);
*/

// Задача 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int Number (int numb)
{
    int des = numb / 10;
    int ed = numb % 10;
    int max = 0;
    if(des>ed)
    {
        max = des;
    }
    else
    {
        max = ed;
    }
    return max;
}
int randNumber = new Random().Next(10,100);
Console.WriteLine($"Current random two-digit number is  {randNumber}");

int result = Number(randNumber);
Console.WriteLine($"Max number is {result}");



