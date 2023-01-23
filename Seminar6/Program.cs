// задача1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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
