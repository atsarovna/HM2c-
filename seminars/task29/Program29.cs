/* Задача 29: Напишите программу, которая задаёт 
массив из 8 случайных целых чисел и выводит их на экран. 
Диапазон - любое целое число.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];

int min;

Console.Write("Enter minimum number in array: ");
while (!int.TryParse(Console.ReadLine(), out min) || min < 0) //введенную строку записать в переменную до тех пор пока не успешно строка преобразована в число, я буду повторять попытку ввода до тех пор пока это не будет число и не будет положительным. проверка на буквы и отрицательные, если будет так,то будет повторять ввести верное число
{
    Console.WriteLine("Wrong number, try again");
}

int max;

Console.Write("Enter maximum number in array: ");
while (!int.TryParse(Console.ReadLine(), out max) || max < 0) //введенную строку записать в переменную до тех пор пока не успешно строка преобразована в число, я буду повторять попытку ввода до тех пор пока это не будет число и не будет положительным. проверка на буквы и отрицательные, если будет так,то будет повторять ввести верное число
{
    Console.WriteLine("Wrong number, try again");
}

array[0] = min;
array[array.Length - 1] = max;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
    Console.Write(array[i] + " ");
}