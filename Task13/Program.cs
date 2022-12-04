//  Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число n: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

if(n<=99)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    while (n>=999)
    n = n/10; 
int result = n%10;

Console.WriteLine(result);
}



