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
