/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

int lines = InputValue("lines");
int columns = InputValue("columns");

int[,] array = new int[lines, columns];

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();

SumMinimal(array);
Console.WriteLine();

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

//поиск строки с наименьшей суммой элементов
void SumMinimal(int[,] inputArray)
{
    int index = 0;
    int countLines = 1;
    int sum = 0;
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        sum2 = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum2 += inputArray[i, j];
        }
        if (sum2 < sum1)
        {
            sum = sum2;
            index = i + 1;
        }
        sum1 = sum2;
        Console.WriteLine($"Sum of elements in {countLines} line: {sum2}");

        countLines++;
    }
    Console.WriteLine($"Minimal sum of elements in {index} line: {sum}");
    Console.WriteLine($"Number of line is: {index}");
}



