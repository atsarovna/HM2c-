/* Задача 29: Напишите программу, которая задаёт 
массив из 8 случайных целых чисел и выводит их на экран. 
Диапазон - любое целое число.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];

Console.Write("Enter minimum number in array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum number in array: ");
int max = Convert.ToInt32(Console.ReadLine());

array [0] = min;
array [array.Length - 1] = max;

for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(min,max);
    Console.Write(array[i]+ " ");
}