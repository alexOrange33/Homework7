// Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

System.Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите минимальное значение элементов:");
int minValue = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите максимальное значение элементов:");
int maxValue = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите искомое число:");
int value = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, minValue, maxValue);
FindValue(array, value);


//-----------metods--------------


void FindValue(int[,] array, int value)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value) result = true;
            
            if (result) break;
        }
    }
    PrintArray(array);
    if(result) System.Console.WriteLine($"Число {value} найдено");
    else System.Console.WriteLine($"Число {value} не найдено");
    
}

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