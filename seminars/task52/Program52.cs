/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int lines = InputValue("lines");
int columns = InputValue("columns");

int[,] arr = new int[lines, columns];

FillArray(arr, 0, 10);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();

ArithmeticMeanColumn(arr);

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

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Console.Write(Array[i, j] + " ");
        Console.WriteLine();
    }
}

//поиск среднего арифметического
void ArithmeticMeanColumn(int[,] inputArray)
{
    int count = 1;
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        double sum = 0;
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            sum += inputArray[j, i];
            arithmeticMean = sum / lines;
        }

        Console.WriteLine($"Sum of elements in {count} column: {sum}");
        Console.WriteLine($"Arithmetic mean of {count} column: {Math.Round(arithmeticMean, 2)}");
        Console.WriteLine();
        count++;
    }
}