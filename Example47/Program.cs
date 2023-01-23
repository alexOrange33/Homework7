// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

System.Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите количество столбцов:");
int coluns = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите минимальное значение элементов:");
int minValue = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите максимальное значение элементов:");
int maxValue = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, coluns,minValue,maxValue);
PrintArray(array);

//--------------------metods--------------------------------
double[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue,maxValue),1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}