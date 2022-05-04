/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 
Длина массива задается с терминала.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int count;
Console.Write("Enter the positive integer number of array: ");

while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
{
    Console.WriteLine("Wrong number, try again");
}

int[] array = new int[count]; 

FillArray(array);
PrintArray(array);

int sum = 0;
for(int i = 0; i < array.Length; i++ )
{
    if(i%2 == 1)
    {
    sum+=array[i];
    }
    else
    {
        sum+=0;
    }
}
Console.Write($" -> {sum}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
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