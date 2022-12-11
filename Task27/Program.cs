// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine());

void SumNums(int num) 
{

    int Summ = 0;
    while (num != 0)
    {
        Summ += num%10;
        num/=10;
    }
    Console.Write($"Сумма чисел: {Summ}");
}
SumNums(num);

