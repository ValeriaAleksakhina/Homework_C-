// Задача 26: Напишите программу, которая принимает на 
// вход число и выдаёт количество цифр в числе.
// 456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());

void ost (int num) // объявление метода
{
    int count = 0;

    while (num != 0)
    {
        num = num/10;
        count ++;
    }
    Console.WriteLine($"Количество цифр в числе: {count}");
}

ost (x);