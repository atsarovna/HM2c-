/* Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. 
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int m = InputValue("lines");
int n = InputValue("columns");

int[,] arr = new int[m, n];

FillArray(arr, 1, 10);
PrintArray(arr);

QadrantArray(arr);

Console.WriteLine();

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
            //Console.WriteLine($"array[{i},{j}] = {array[i, j]}");
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void QadrantArray(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i += 2)
        for (int j = 2; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];

}
