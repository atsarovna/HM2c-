/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */
/*  Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза */

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

int sum = 0;

double NumberOf(double number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number = array[i,j])
            {
                count++;
            }
        }
    }
 }