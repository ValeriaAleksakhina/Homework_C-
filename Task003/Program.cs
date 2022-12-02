// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

try
{

    Console.WriteLine("Введите число a1");
    int a1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число b1");
    int b1 = int.Parse(Console.ReadLine());

    if (a1 > b1)
    {
        int c = a1;
        a1 = b1;
        b1 = c;
    }

    if (b1 % a1 == 0)
    {
        Console.WriteLine($"Число {b1} кратно числу {a1}");
    }
    else
    {
        int result = b1 % a1;
        Console.WriteLine($"Число некратно. Остаток равен {result}");
    }
}

catch
{
    Console.WriteLine("Данные не верны");
}



