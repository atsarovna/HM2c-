/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int count;
Console.Write("Enter count of numbers in a array: "); //вводим кол-во элементов в массиве

while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
{
    Console.WriteLine("Wrong number, try again");
}

int[] array = new int[count];
FillArray(array);
PrintArray(array);

int countNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        countNumbers++;
    }
}

Console.WriteLine($"Count of numbers greater than 0 in this array are {countNumbers}");

void FillArray(int[] array)
{
    int position = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {position} number :");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
        position++;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1)
            Console.Write($"{array[i]} -> ");
        else
            Console.Write($"{array[i]}, ");
    }
}





