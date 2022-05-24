/* Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int m = InputValue("lines");
int n = InputValue("columns");

double[,] arr = new double[m, n];

FillArray(arr, -10, 10);
PrintArray(arr);

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

void FillArray(double[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round((rnd.NextDouble() * (maxValue - minValue) + minValue), 1);
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

