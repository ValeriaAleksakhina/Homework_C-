// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int n = num;
int a = 0;
int b = 0;

while(n>0)
{
    a = n%10;
    b = b*10+a;
    n = n/10;
}

if (num == b)
{
    Console.WriteLine("Число является палиндромом");

}
else
{
Console.WriteLine("Число не является палиндромом");
}