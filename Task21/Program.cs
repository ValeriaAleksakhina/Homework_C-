// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Xa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Ya: ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Za: ");
int Za = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Xb: ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Yb: ");
int Yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Zb: ");
int Zb = int.Parse(Console.ReadLine()!);



double result = Math.Sqrt((Xb-Xa)*(Xb-Xa)+(Yb-Ya)*(Yb-Ya)+(Zb-Za)*(Zb-Za));

Console.WriteLine(result);