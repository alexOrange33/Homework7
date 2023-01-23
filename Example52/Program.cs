// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


System.Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите минимальное значение элементов:");
int minValue = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите максимальное значение элементов:");
int maxValue = int.Parse(Console.ReadLine()!);



int[,] array = GetArray(rows, columns, minValue, maxValue);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
AverageColums(array);



//-------metod---------
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void AverageColums(int[,] array)
{
    double[] result = new double[array.GetLength(0)];
    double temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[j, i];
        }
        result[i] = Math.Round(temp / array.GetLength(1), 1);
    }
    System.Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", result)}");
}
