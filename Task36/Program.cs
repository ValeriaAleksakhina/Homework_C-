// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
void PrintArray(int[]arr)
{
  for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }  
}

int[] array = GetArray(20, 0, 99);
PrintArray(array);

int SumNums(int[] array)
{
int sum = 0;

{
    for(int j = 1; j<array.Length; j+=2)
    {
       sum = sum + array[j];
    }
}
return sum;
}


Console.WriteLine($"всего {array.Length} чисел, сумма элементов cтоящих на нечётных позициях = {SumNums (array)}");