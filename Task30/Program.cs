// Программу кот выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке
// [1 0 1 1 1 0 1 1]

int [] array = new int [8];

int i = 0;

while (i<=7)
{
    int K = new Random().Next(0,2);
    array[i] = K;
    Console.Write(array[i] + " ");
    i++;
}


