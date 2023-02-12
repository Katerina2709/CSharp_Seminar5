// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
 
Console.Write ("Введите длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
if (leng >= 1)
{
   Console.Write ("Введите начало диапазона чисел в массиве: ");
   int d1 = Convert.ToInt32(Console.ReadLine());
   Console.Write ("Введите конец диапазона: ");
   int d2 = Convert.ToInt32(Console.ReadLine());
   
   int[] array1 = FillArray(leng, d1, d2); // задаём массив из leng элементов в диапазоне от d1 до d2
   
   int sum = 0;
   for (int i = 1; i < array1.Length; i = i + 2)  // считаем сумму чисел с нечетными индексами
        sum += array1 [i]; 
   Console.WriteLine ($"В массиве [{string.Join (", ", array1)}] сумма элементов с нечетными индексами -> {sum}");
}        
else
{
    Console.Write ("Неверная длина массива");
}