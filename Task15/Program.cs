// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if(number == 1)
{
    Console.WriteLine("Сегодня понедельник, рабочий день.");
}
if(number == 2)
{
    Console.WriteLine("Сегодня вторник, рабочий день.");
}
if(number == 3)
{
    Console.WriteLine("Сегодня среда, рабочий день.");
}
if(number == 4)
{
    Console.WriteLine("Сегодня четверг, рабочий день.");
}
if(number == 5)
{
    Console.WriteLine("Сегодня пятница, рабочий день.");
}
if(number == 6)
{
    Console.WriteLine("Ура! Сегодня суббота, выходной!");
}
if(number == 7)
{
    Console.WriteLine("Ура! Сегодня воскресенье, выходной!");
}
if(number<1)
{
    Console.WriteLine("Некорректные исходные данные");
}
if(number>7)
{
    Console.WriteLine("Некорректные исходные данные");
}