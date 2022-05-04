/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] numbers = new int[4];
FillArray(numbers, -9, 9);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
    {
        if (i == 0)
            Console.Write($" -> [{numbers[i]}, ");
        else if (i == numbers.Length - 1)
            Console.Write($"{numbers[i]}]");
        else
            Console.Write($"{numbers[i]}, ");
    }
}

void FillArray(int[] arr, int minValue, int maxValue)
{
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
        arr[i] = random.Next(minValue, maxValue + 1);
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
    }
}