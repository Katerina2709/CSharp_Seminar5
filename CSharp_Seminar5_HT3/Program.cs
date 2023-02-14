// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray (int len, double dStart, double dEnd) 
// заполнение массива произвольными вещественными числами в диапазоне от dStart до dEnd 
{
    double[] arrayNumb = new double [len];
    for (int i = 0; i< len; i++)
    {
        arrayNumb[i] = new Random().NextDouble(); 
        // определили случайным образом вещественное число в диапазонне от 0 до 1
        arrayNumb[i] = Math.Round(arrayNumb[i] * (dEnd - dStart) + dStart, 2);
        // расширили диапазон до [dStart, dEnd] и округлили до 2 знаков после запятой
    } 
    return arrayNumb;
}

double ValueMax (double[] array)
// нахождение максимального элемента
{
    double max = array [0];
    int i = 1;
    while (i < array.Length)
    {
         if (array [i] > max)
         {           
            max = array [i]; 
         }
         i++;
    }
    return Math.Round (max, 2);
}

double ValueMin (double[] array)
// нахождение минимального элемента
{
    double min = array [0];
    int i = 1;
    while (i < array.Length)
    {
         if (array [i] < min)
         {           
            min = array [i]; 
         }
         i++;
    }
    return Math.Round (min, 2);
}

Console.Write ("Введите длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
if (leng >= 1)
{
   Console.Write ("Введите начало диапазона чисел в массиве: ");
   double d1 = Convert.ToDouble(Console.ReadLine());
   Console.Write ("Введите конец диапазона: ");
   double d2 = Convert.ToDouble(Console.ReadLine());
   
   double[] array1 = FillArray(leng, d1, d2); // задаём массив из leng элементов в диапазоне от d1 до d2
   double result = Math.Round(ValueMax (array1) - ValueMin (array1), 2);
   Console.WriteLine ($"В массиве [{string.Join (", ", array1)}] разность между максимальным и минимальным элементами -> {result}");
}        
else
{
    Console.Write ("Неверная длина массива");
}