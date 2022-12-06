// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату Xa: ");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Введите координату Ya: ");
int Ya = int.Parse(Console.ReadLine());

Console.Write("Введите координату Xb: ");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Yb: ");
int Yb = int.Parse(Console.ReadLine());



double z = Math.Sqrt((Xb-Xa)*(Xb-Xa)+(Yb-Ya)*(Yb-Ya));
double result = z;
Console.WriteLine(result);




