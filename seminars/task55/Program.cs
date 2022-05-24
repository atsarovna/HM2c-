/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

//замена строк на столбцы
void SwapLines(int[,] inputArray)
{
    if (inputArray.GetLength(0) == inputArray.GetLength(1))
        for (int i = 0; i < inputArray.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < inputArray.GetLength(1); j++)
            {
                int temp = inputArray[i, j];
                inputArray[i, j] = inputArray[j, i];
                inputArray[j, i] = temp;



            }
        }
    else
        Console.WriteLine("Count of lines != count of columns. Can't be replaced.");
}
