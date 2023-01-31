// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*

int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] NewRowsArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Отсортированный массив: ");
Console.WriteLine();
Show2dArray(NewRowsArray(myArray));
*/

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
 {
     Console.Write("Введите количество строк: ");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите количество столбцов: ");
     int columns = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите минимальное значение элемента: ");
     int min = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите максимальное значение элемента: ");
     int max = Convert.ToInt32(Console.ReadLine());

     int[,] array = new int[rows, columns];
     for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
             array[i,j] = new Random().Next(min, max + 1);
     return array;
 }

 void Show2dArray(int[,] array)
 {
     for(int i = 0; i < array.GetLength(0); i++)
         {
             for(int j = 0; j < array.GetLength(1); j++)
                 Console.Write(array[i,j] + " ");
             Console.WriteLine();
         }
     Console.WriteLine();
 }

 int SearchMinSumInRow(int[,] array)
 {
     int minSum = 0;
     int numRow = 0;
     for(int i = 0, j = 0; j < array.GetLength(1); j++) 
         minSum = minSum + array[i, j];

     for(int i = 1; i < array.GetLength(0); i++)
     {
         int sum = 0;
         for(int j = 0; j < array.GetLength(1); j++)
             sum += array[i, j];
         if(sum < minSum) 
         {
             minSum = sum;
             numRow = i;
         }
     }
     return numRow + 1;
 }

 int[,] array = CreateRandom2dArray();
 Show2dArray(array);
 Console.WriteLine("Номер строки с наименьшей суммой элементов: " + SearchMinSumInRow(array));
 */

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
 {
     Console.Write("Введите количество строк: ");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите количество столбцов: ");
     int columns = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите минимальное значение элемента: ");
     int min = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите максимальное значение элемента: ");
     int max = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine();
     int[,] array = new int[rows, columns];
     for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
             array[i,j] = new Random().Next(min, max + 1);
     return array;
 }

 void Show2dArray(int[,] array)
 {
     for(int i = 0; i < array.GetLength(0); i++)
         {
             for(int j = 0; j < array.GetLength(1); j++)
                 Console.Write(array[i,j] + " ");
             Console.WriteLine();
         }
     Console.WriteLine();
 }

 int[,] MatrixMultiplication(int[,] array1, int[,] array2)
 {
     int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
     if (array1.GetLength(1) == array2.GetLength(0))
     {
         for (int i = 0; i < array1.GetLength(0); i++)
             for (int j = 0; j < array2.GetLength(1); j++)
             {
                 result[i, j] = 0;
                 for (int k = 0; k < array1.GetLength(1); k++)
                     result[i, j] += array1[i, k] * array2[k, j];
             }
     }
     return result;
 }

 int [,] array1 = CreateRandom2dArray();
 int [,] array2 = CreateRandom2dArray();
 Show2dArray(array1);
 Show2dArray(array2);

 Show2dArray(MatrixMultiplication(array1, array2));
*/

// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
Console.Write("Input a X of 3D matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y of 3D matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Z of 3D matrix: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[x, y, z];
void CreateRandom3dArray(int[,,] array3D)
{
  int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int number;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    array[i] = new Random().Next(10, 100);
    number = array[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (array[i] == array[j])
        {
          array[i] = new Random().Next(10, 100);
          j = 0;
          number = array[i];
        }
        number = array[i];
      }
    }
  }
  int count = 0;
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = array[count];
        count++;
      }
    }
  }
}
void Show3dArray(int[,,] array3D)
{
  for(int i = 0; i < array3D.GetLength(0); i++)
  {
    for(int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.WriteLine();
      for (int k = 0; k < array3D.GetLength(2); k++)
        Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
    }
  }
  Console.WriteLine();
}
CreateRandom3dArray(array3D);
Show3dArray(array3D);
*/

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
 
 int[,] SpiralArray()
 {
   Console.Write("Input a size array: ");
  int size = Convert.ToInt32(Console.ReadLine());
    
  int[,] array = new int[size, size];
  int num = 1;
  int minRow = 0;
  int maxRow = size-1;
  int minCol = 0;
  int maxCol = size-1;
  while (num <= array.GetLength(0) * array.GetLength(1))
  {
    for (int i = minCol; i <= maxCol; i++)
    {
      array[minCol, i] = num;
      num++;
    }
    minRow++;
    for (int i = minRow; i <= maxRow; i++)
    {
      array[i, maxCol] = num;
      num++;
    }
    maxCol--;
    for (int i = maxCol; i >= minCol; i--)
    {
      array[maxRow, i] = num;
      num++;
    }
    maxRow--;
    for (int i = maxRow; i >= minRow; i--)
    {
      array[i, minCol] = num;
      num++;
    }
    minCol++;
  }
  return array;
}
 void Show2dArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

 int[,] myArray = SpiralArray();
 Show2dArray(myArray);
 */