// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//  void ShowNums(int num)
//  {
//      Console.Write(num + " ");
//      if(num > 1) ShowNums(num - 1);
//  }

//  Console.Write("Введите число N: ");
//  int n = Convert.ToInt32(Console.ReadLine());
//  ShowNums(n);


//  // Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


//  int GetSumNums(int m, int n)
//  {
//      if(m < n) return m + GetSumNums(m + 1, n);
//      else if(n < m) return m + GetSumNums(m - 1, n);
//      else return m;
//  }

//  Console.Write("Введите значение первого числа: ");
//  int m = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите значение второго числа: ");
//  int n = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Сумма натуральных чисел = " + GetSumNums(m, n));


//  // Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


 int Akkerman (int m, int n)
 {
     if (m == 0) return n + 1;
     else if (m > 0 && n == 0) return Akkerman((m - 1), 1);
     else if (m >= 0 && n >= 0) return Akkerman((m - 1), Akkerman(m, n - 1));
     else return 0;
 }

 Console.Write("Введите значение первого числа: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите значение второго числа: ");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.Write("A(m,n) = " + Akkerman(m, n));
