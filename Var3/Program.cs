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
