/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int m = InputValue("lines"); //строки
int n = InputValue("columns"); //столбцы

int[,] arr = new int[m, n];

FillArray(arr);

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

void FillArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
        for (int j = 0; j < inputArray.GetLength(1); j++)
            inputArray[i, j] = i + j;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
            Console.Write(inputArray[i, j] + " ");
        Console.WriteLine();
    }
}