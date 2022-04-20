/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125 */

/* 3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */

Console.Write("Enter number to calculate cubes from 1 to N. N = ");
int N = Convert.ToInt32(Console.ReadLine());

double result = 0;
int index = 1;

if (N <= 0)
{
    N = -N;
}

while (index <= N)
{
    result = cube(index);
    Console.WriteLine($"Cube for {index}: -> {result} ");
    index++;
}

double cube(double number)
{
    return Math.Pow((number), 3);
}