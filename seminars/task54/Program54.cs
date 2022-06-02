/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

int lines = InputValue("lines");
int columns = InputValue("columns");

int[,] array = new int[lines, columns];

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();

SortingLines(array);
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

//сортировка цифр в каждой строке по убыванию
void SortingLines(int[,] inputArray)
{
    for (int k = 0; k < lines; k++) //это заполнение, k - номер текущей строки
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 1; j < inputArray.GetLength(1); j++)
            {

                if (inputArray[k, j] > inputArray[k, j - 1])
                {
                    int temp = inputArray[k, j];
                    inputArray[k, j] = inputArray[k, j - 1];
                    inputArray[k, j - 1] = temp;
                }
            }
        }
    }
}
