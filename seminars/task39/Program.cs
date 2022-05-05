/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] array = GetArray(5);
PrintArray(array);

//цикл для свопа последнего с первым
for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];// - i так как с конца двигаемся
    array[array.Length - 1 - i] = temp;
}
PrintArray(array);

//метод,который создает массив
int[] GetArray(int length) //методу передаем кол-во элементов в массиве
{
    int[] newArray = new int[length]; //создать новый массив(проинициализировать), массив размером length
    FillArray(newArray); //заполняем массив
    return newArray; //этот новый массив возвращаем
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1)
            Console.WriteLine($"{array[i]}]");
        else
            Console.Write($"{array[i]}, ");
    }
}