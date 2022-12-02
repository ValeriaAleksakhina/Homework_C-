// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

 Console.WriteLine("Введите число num1");
 int num1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите число num2");
 int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
    {
        int num3 = num1;
        num1 = num2;
        num2 = num3;
    }

if(num2 == num1*num1)
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else{
     Console.WriteLine($"Число {num2} не является квадратом числа {num1}");
}