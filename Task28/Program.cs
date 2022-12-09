// Программу, кот принимает на вход число N
// и выдает произведение чисел от 1 до N


Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

void proizv(int num) 
{
    int i = 1;
    int proizvedenie = 1;
    while (i  != N+1)
    {
        proizvedenie *= i;
        i++;
    }
    Console.Write($"Произведение равно: {proizvedenie}");
}
proizv(N);