
//Задача 37
// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

Console.WriteLine("Задача 37: Найдите произведение пар чисел в одномерном массиве.");
Console.WriteLine("Парой считаем первый и последний элемент, второй и предпоследний и т.д.");

int N = 10;
int[] array = new int[N];
Console.Write("Массив" + " : ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.Write("Произведение пар чисел" + " : ");

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)

{
    Console.Write(array[i] * array[j] + " ");
    j--;
}



// Задача 37 (Вариант 2) 
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

using System;

const int size_N=16;

int [] array = new int[size_N];

void print_array(int [] local_array)
{
Console.Write("[");
for(int i=0; i < local_array.Length-1; i++)
     {
         Console.Write($"{local_array[i]}, ");
     }
     Console.WriteLine($"{local_array[local_array.Length-1]}]");
 }

 void init_array()
 {
     Random rnd = new Random();
     for(int i=0; i<size_N; i++)
     {
         array[i]=rnd.Next(-10,11);
     }
 }

 int [] process_array2(int [] local_array)
 {
   int [] ret_array = new int[local_array.Length/2];
   for (int i=0; i<ret_array.Length;i++)
   {
       ret_array[i] = local_array[i] * local_array[local_array.Length - i -1];
   }
   return ret_array;
 }

 init_array();
 print_array(array);
 int [] array1 = process_array2(array);
 print_array(array1);
 
 
 //Задача 37 (Вариант 3) 
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] startAr = { 1, 2, 3, 4, 5, 6};
int[] resAr = new int[3] ;

void MultArray(int[] array, int[] res)
{

 int first = 0;
 int last = array.Length - 1;
 int index = 0;

 while (last > first)
    {
    
     res[index] = array[first] * array[last];
     first++;
     last--;
     index++;
    }
}

void Print(int[] arr)
{
     for(int i = 0; i < arr.Length; i++)
     {
         Console.Write($"{arr[i]}  ");
     }
}
 MultArray(startAr, resAr);
 Print(startAr);
 Console.WriteLine();
 Print(resAr);
