﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

double count = 1;

while (count<=N)
{
    Console.Write(Math.Pow(count,2) + " ");
    //count = count+1;
    count++;

}