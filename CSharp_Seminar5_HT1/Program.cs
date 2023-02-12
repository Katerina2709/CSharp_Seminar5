// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray (int len, int dStart, int dEnd) 
// заполнение массива произвольными числами в диапазоне от dStart до dEnd 
{
    int[] arrayNumb = new int[len];
    for (int i = 0; i< len; i++)
    {
        arrayNumb[i] = new Random().Next(dStart, dEnd + 1);
    }
    return arrayNumb;
}
 
int CountItem (int[] array, int flag)
// подсчет количества четных (flag = 0) или нечетных (flag = 1) чисел в массиве
{
   int count = 0;
   if (flag == 0 || flag == 1)
   {
       for (int i = 0; i < array.Length; i++)
       {
          if (array [i] % 2 == flag)
             count++;
       }
   }   
    else
   {
      Console.WriteLine ("Неверное значения аргумента");
      count = -1;
   }
   return count;
}

Console.Write ("Введите длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
if (leng >= 1)
{
   int[] array1 = FillArray(leng, 100, 1000);
   // заполнение массива случайными положительными трехзначными числами
   int countChet = CountItem (array1, 0);
   // подсчет количества четных чисел в массиве
   Console.WriteLine ($"В массиве [{string.Join (", ", array1)}]  четных чисел -> {countChet}"); 
}
else
{
    Console.WriteLine ("Неверная длина массива");
}