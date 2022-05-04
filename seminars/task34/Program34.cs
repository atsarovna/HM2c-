/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. 
Длина массива задается с терминала.
[345, 897, 568, 234] -> 2 */

int count;
Console.Write("Enter the positive integer number of array: ");

while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
{
    Console.WriteLine("Wrong number, try again");
}

int[] array = new int[count]; 

FillArray(array);
PrintArray(array); 

int number = 0;
for(int i = 0; i < array.Length; i++ )
{
    if(array[i]%2 == 0)
    {
    number+=1;
    }
    else
    {
        number+=0;
    }
}
Console.Write($" -> {number}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1)
            Console.Write($"{array[i]}]");
        else
            Console.Write($"{array[i]}, ");
    }
}

