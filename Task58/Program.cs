// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк 1 матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows1, columns1);
int[,] array2 = GetArray(rows2, columns2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();



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
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] resultArray = new int [rows1, columns2];

void ResultMatrix(int[,] array1, int[,] array2, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

ResultMatrix(array1, array2, resultArray);
PrintArray(resultArray);