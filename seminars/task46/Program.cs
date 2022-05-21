/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

/* const int m = 4; //задаем кол-во столбцов. const - потому что зафиксированные числа и меняться не будут
const int n = 3; //кол-во строк

int[,] arr = new int[m, n]; // создаю двумерный массив,выделяю память для массива с n строками и m колонками

FillArray(arr, -100, 100); //задаем диапозон случайных чисел

PrintArray(arr);

//заполняю рандомными числами массив от мин до макс
void FillArray(int[,] array, int min, int max)//в скобках аргумент. int[,]- двумерный массив, array - название массива, int min, int max - диапозон
{
    Random rnd = new Random();//генератор случайных чисел

    for (int i = 0; i < array.GetLength(0); i++) //array.GetLength(0) - функция с аргументом номер размерностию 0 - размерность,первое измерение это будет m
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);
}

//вывожу массив в консоль
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            Console.WriteLine($"array[{i},{j}] = {array[i, j]}");
} */

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++) //цикл строки
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 101);
    }
}

for (int i = 0; i < m; i++) //цикл строки
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}