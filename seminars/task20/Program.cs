// Программа, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

Console.Write("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());

//int count = 1;
//getSquare(N);
//void getSquare(int N)
//{
//    while (count <= N)
//    {
//        int newN = count;
//        count = count * count;  // квадрат числа
//        Console.WriteLine(count + ", ");
//        count = newN + 1;
//    }
//}

if (N < 0)
    N = -N;

int count = 1;

while (count <= N)
{
    int newN = square(count);
    Console.Write(newN + ", ");
    count++;
}

int square(int N)
{
    N = N * N;
    return N;
}