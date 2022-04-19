//Программа, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.Write("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());

double result = 0;
int index = 1;

if (N <= 0)
{
    N=-N;
}

while(index<=N)
{
    result = Square (index);
    Console.Write($"{result} ");
    index++;
}

double Square (double number)
{
    return Math.Pow((number), 2);
}