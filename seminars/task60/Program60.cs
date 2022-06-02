/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Числа выбираются случайно, при этом проверяется, 
что такого числа еще не было. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
 */

int dimension1 = InputValue("dimension 1");
int dimension2 = InputValue("dimension 2");
int dimension3 = InputValue("dimension 3");

int[,,] array = new int[dimension1, dimension2, dimension3];

FillArray(array, 10, 99);
PrintArray(array);
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

void FillArray(int[,,] arr, int min, int max)
{
    int value = 10;
    int[] twoDigitValues = new int[89];
    for (int i = 0; i < twoDigitValues.Length; i++)
        twoDigitValues[i] = value++;

    int minValueIndex = 0;
    for (int d1 = 0; d1 < array.GetLength(0); d1++)
        for (int d2 = 0; d2 < array.GetLength(1); d2++)
            for (int d3 = 0; d3 < array.GetLength(2); d3++)
            {
                int valueIndex = new Random().Next(minValueIndex, twoDigitValues.Length);
                array[d1, d2, d3] = twoDigitValues[valueIndex];
                twoDigitValues[valueIndex] = twoDigitValues[minValueIndex];
                minValueIndex++;
            }
}

    void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"[{i},{j},{k}]{array[i, j, k]} ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
