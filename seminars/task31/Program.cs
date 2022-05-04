/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

int[] numbers = new int[12]; //создать массив из 12 элементов
FillArray(numbers); //заполнить случайными числами от -9 до 9 : FillArray(numbers, -9, 9)
WriteArray(numbers); //вывести массив

/* Найти сумму всех отрицательных элементов и вывести
int sumNegative = SumNeg(numbers);
Console.Writeline($"Cevvf отрицательных элементов массива = {sumNegative}");

Найти сумму всех положительных элементов и вывести
int sumPositive = SumPos(numbers);
Console.Writeline($"Cevvf отрицательных элементов массива = {sumPositive}"); */

int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sumPositive += numbers[i];
    }
    else
    {
        sumNegative += numbers[i];
    }
}
Console.WriteLine($"Sum of positive numbers = {sumPositive}. Sum of negative numbers = {sumNegative}");

void FillArray(int[] array) //заполняю рандомными числами массив //void (int[] array, int minValue, int maxValue)
{
    //или Random random = new Random(); - создали генератор случайных чисел
    for (int i = 0; i < array.Length; i++)
    //или array[i] = random.Next(minValue, maxValue + 1); - array[i] присваиваю очередное рандомное целое число от минимального до максимального - 1(потому что граница не включена)
    {
        array[i] = new Random().Next(-9, 10); //это тогда не нужно
    }
}

void WriteArray(int[] array) //вывожу массив
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1)
            Console.Write($"{array[i]}]");
        else
            Console.Write($"{array[i]}, ");
        //Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//2 вариант
//решение задачи:
/* 1. создать массив из 12 элементов
int[] array = new int[12]; 

2.заполнить его случайными числами от -9 до 9
FillArray(array, -9, 9);

3.вывести массив
PrintArray(array); 

4.Найти сумму всех отрицательных элементов и вывести
int sumNegative = SumNeg(numbers);
Console.Writeline($"Сумма отрицательных элементов массива = {sumNegative}");

5.Найти сумму всех положительных элементов и вывести
int sumPositive = SumPos(numbers);
Console.Writeline($"Сумма отрицательных элементов массива = {sumPositive}");
--------------------------------------------
6.Заполнить массив - функция
void FillArray(int[] arr, int minValue, int maxValue)
{
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    arr[i] = random.Next(minValue, maxValue + 1);
}
7.вывести массив - функция
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    Console.WriteLine($"arr[{i}] = {arr[i]}");
}
8.найти сумму отрицательных - функция
int SumNeg(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0)
        {
            sum+=arr[i];
        }
    }
    return sum;

8.найти сумму положительных - функция
int SumPos(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++) //можно без {} так как один оператор
        if(arr[i]>=0)
            sum+=arr[i];

    return sum;    
}
*/
