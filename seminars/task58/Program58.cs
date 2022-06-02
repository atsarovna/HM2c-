/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

int m = InputValue("lines");
int n = InputValue("columns");

int[,] arr = new int[m, n];

FillArray(arr, 0, 10);
Console.WriteLine();
PrintArray(arr);
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

void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);
}

void PrintArray(int[,] Inputarray)
{
    for (int i = 0; i < Inputarray.GetLength(0); i++)
    {
        for (int j = 0; j < Inputarray.GetLength(1); j++)
        {
            Console.Write(Inputarray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int x = InputValue2("lines");
int y = InputValue2("columns");

int[,] arr2 = new int[x, y];

FillArray2(arr2, 0, 10);
Console.WriteLine();
PrintArray2(arr2);
Console.WriteLine();

int InputValue2(string element)
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

void FillArray2(int[,] array2, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array2.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            array2[i, j] = rnd.Next(min, max);
}

void PrintArray2(int[,] Inputarray2)
{
    for (int i = 0; i < Inputarray2.GetLength(0); i++)
    {
        for (int j = 0; j < Inputarray2.GetLength(1); j++)
        {
            Console.Write(Inputarray2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

MultiplicationMatrix(arr, arr2);
Console.WriteLine();

void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        var resultMatrix = new int[arr.GetLength(0), arr2.GetLength(1)];

        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Can't be multipled.Count of columns from 1 matrix not equal count of lines from 2 matrix.");
    }
}