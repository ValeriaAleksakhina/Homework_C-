﻿// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
PrintArray(GetArrayChangeRows(array));

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArrayChangeRows(int[,] inArray) // создаем второй массив
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == 0) // первую строчку меняем с последней
            {
                result[i, j] = inArray[inArray.GetLength(0) - 1, j];
            }
            else if (i == inArray.GetLength(0) - 1) // последнюю строчку меняем с первой
            {
                result[i, j] = inArray[0, j];
            }
            else
            {
                result[i, j] = inArray[i, j];
            }
        }
    }
    return result;
}
