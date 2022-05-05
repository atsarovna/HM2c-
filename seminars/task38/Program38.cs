/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным значением элементов массива. 
Длина массива задается с терминала.
[3 7 22 2 78] -> 76 */

int count;
Console.Write("Enter the integer number of array: ");

while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
{
    Console.WriteLine("Wrong number, try again");
}

double[] array = new double[count];

FillArray(array);
PrintArray(array);

double max = 0;
double min = 0;
double diff = 0;
for (int i = 0; i < array.Length; i++)
{
    if (max <= array[i])
    {
        max = array[i];
    }
    else
    {
        min = array[i];
    }
    diff = max - min;
}
Console.Write($" -> {diff}");

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(double[] array)
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
