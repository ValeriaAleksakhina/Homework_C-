// Напишите программу, которая по заданному 
//номеру четверти, показывает диапазон возможных
//координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Значение X от 0 до +бесконечности, значение Y от 0 до +бесконечности ");
}
if (num == 2)
{
    Console.WriteLine("Значение X от 0 до -бесконечности, значение Y от 0 до +бесконечности ");
}

if (num == 3)
{
    Console.WriteLine("Значение X от 0 до -бесконечности, значение Y от 0 до -бесконечности ");
}
if (num == 4)
{
    Console.WriteLine("Значение X от 0 до +бесконечности, значение Y от 0 до -бесконечности ");
}