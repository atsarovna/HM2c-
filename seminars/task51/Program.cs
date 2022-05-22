/* Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int m = InputValue("lines");
int n = InputValue("columns");

int[,] arr = new int[m, n];

FillArray(arr, 0, 10);

PrintArray(arr);
Console.WriteLine($"Sum of the main diagonale is: {SumDiag(arr)}");

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumDiag(int[,] arrayIn)
{
    int minValue = Min(m, n);
    int sum = 0;
    for (int i = 0; i < minValue; i++)
        sum += arrayIn[i,i];

    return sum;
}

int Min(int a, int b)
{
    if (a<b) return a;
    else return b;
}