// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива ");
int N = int.Parse(Console.ReadLine());

void massive(int dlina)

{
    int[] array = new int[dlina];
    int i = 0;

    while (i < dlina)
    {
        int k = new Random().Next(0, 99);
        array[i] = k;
    if (i == 0)
    {
        Console.Write("[ " + array[i] + ", ");
    }
    if (i == dlina - 1)
    {
        Console.Write(array[i] + " ]");
    }
    if (i >0 && i < dlina - 1) 
    {
        Console.Write(array[i] + ", ");
    }
        i++;
    }

}

massive(N);