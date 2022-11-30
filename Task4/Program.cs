//Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());

int Max = a;

if (a>Max) Max = a;
if (b>Max) Max = b;
if (c>Max) Max = c;

Console.Write ("Max = ");
Console.WriteLine(Max);


