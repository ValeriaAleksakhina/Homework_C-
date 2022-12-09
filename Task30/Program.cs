// Программу кот выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке
// [1 0 1 1 1 0 1 1]


//Console.WriteLine("Введите длину массива: ");
//nt N = int.Parse(Console.ReadLine());

// void massive(int dlina)
//{
  //  int[] array = new int[dlina];
  //  int i = 0;

   // while (i<dlina)
    //{
   //     int K = new Random().Next(0,2);
   // array[i] = K;
  //  if (i == 0)
  //  {
   // Console.Write("[" + array[i] + " , ");
  //  }
 //   if (i == 7)
  //  {
  //  Console.Write(array[i] + " ] ");
  //  }
  //  if (i>0 && i<7)
  //  {
   //    Console.Write(array[i] + " , "); 
  //  }
  //  i++;
 //   }
//}







int [] array = new int [8];

int i = 0;

while (i<=7)
{
    int K = new Random().Next(0,2);
    array[i] = K;
    if (i == 0)
    {
    Console.Write("[" + array[i] + " , ");
    }
    if (i == 7)
    {
    Console.Write(array[i] + " ] ");
    }
    if (i>0 && i<7)
    {
       Console.Write(array[i] + " , "); 
    }
    i++;
}


