/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
 */

int lines = InputValue("lines");
int columns = InputValue("columns");

int[,] array = new int[lines, columns];

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();

SwapLines(array);
Console.WriteLine();
PrintArray(array);

int InputValue(string element)
{
    int value;
    Console.Write($"Enter count of {element}: ");
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Error. Try again.");
        Console.Write($"Enter count of {element}: ");
    }
    return value;
}

void FillArray(int[,] arr, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(min, max);
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
         Console.WriteLine();
    }
}

//смена первой и последней строки
void SwapLines(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)

    {
        int temp = arr[0, j];
        arr[0, j] = arr[lines - 1, j];
        arr[lines - 1, j] = temp;
    }
}
