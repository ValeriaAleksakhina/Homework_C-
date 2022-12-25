// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine()!);

void SumNums(int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;1
    }
    sum = sum + (m++);
    SumNums(m, n, sum);
}

SumNums(m, n, 0);