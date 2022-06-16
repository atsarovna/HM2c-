/* Задача 62: Заполните спирально массив 4 на 4.
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

int N = 4;
int[,] array = new int[N, N];

FillArraySnail(array);
PrintArray(array);

void FillArraySnail(int[,] arr)
{
    int num = 1;
    
    for (int num2 = 0; num2 < arr.GetLength(0) - 2; num2++)
    {
        for (int i = 0 + num2; i < arr.GetLength(0) - num2; i++)
        {
            arr[0 + num2, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + num2; i < arr.GetLength(1) - num2; i++)
        {
            arr[i, N - 1 - num2] = num;
            num++;
        }
        num--;
        for (int i = arr.GetLength(0) - 1 - num2; i >= 0 + num2; i--)
        {
            arr[N - 1 - num2, i] = num;
            num++;
        }
        num--;
        for (int i = arr.GetLength(1) - 1 - num2; i >= 1 + num2; i--)
        {
            arr[i, 0 + num2] = num;
            num++;
        }
    }
}

// Method to print arrays, pads numbers so they line up in columns
void PrintArray(int[,] array)
{
int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;
 
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j].ToString().PadLeft(n, ' '));
        }
        Console.WriteLine();
    }
}