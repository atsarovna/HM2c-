/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
*/

int lines = InputValue("lines");
int columns = InputValue("columns");

int[,] arr = new int[lines, columns];

FillArray(arr, 0, 10);
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

//поиск элемента
Console.Write("Enter number of line in the array: ");
int numberOfLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of column in the array: ");
int numberOfcolumn = Convert.ToInt32(Console.ReadLine());

if (numberOfLine <= lines && numberOfcolumn <= columns)
    Console.WriteLine($"{numberOfLine},{numberOfcolumn} -> {arr[numberOfLine - 1, numberOfcolumn - 1]}");
else
    Console.WriteLine($"{numberOfLine},{numberOfcolumn} -> there is no such number in the array.");


void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);
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





