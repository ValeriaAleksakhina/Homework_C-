﻿// Задача 43. Напишите программу, которая найдёт точку пересечения
 //двух прямых, заданных уравнениями
 // y = k1 * x + b1, y = k2 * x + b2;
 //значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)




Console.Write("Введите k1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
 
void Result(double k1, double k2, double b1, double b2)
{
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);

if(k1 == k2 && b1 !=b2) Console.WriteLine("Прямые параллельны");
else if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine($"Пересечение в точке с координатами: (X= {x}; Y= {y})");
}
Result(K1, K2, B1, B2);

