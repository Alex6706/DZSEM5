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
