// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size, double minValue, double maxValue)
{
   double[] res = new double[size];
    for(int i=0; i<size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble()*10,2);
    }
    return res;
}
void PrintArray(double[]arr)
{
  for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }  
}

double[] array = GetArray(5, 0, 10);
PrintArray(array);


double max = 0;
double min = 10;
double result = 0;

double Result (double max, double min)
{
    for(int j = 0; j<array.Length; j++)
{
   if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
    }  
    result = max - min;
    return result;
}

Result(max, min);
Console.WriteLine($"-->> Разница между максимальным и минимальным числом равна {result}");