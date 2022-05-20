/* Задача 29: Напишите программу, которая задаёт 
массив из 8 случайных целых чисел и выводит их на экран. 
Диапазон - любое целое число.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
/* 
int[] array = new int[8];

int min;

Console.Write("Enter minimum number in array: ");
while (!int.TryParse(Console.ReadLine(), out min) || min < 0) //введенную строку записать в переменную до тех пор пока не успешно строка преобразована в число, я буду повторять попытку ввода до тех пор пока это не будет число и не будет положительным. проверка на буквы и отрицательные, если будет так,то будет повторять ввести верное число
{
    Console.WriteLine("Wrong number, try again");
}

int max;

Console.Write("Enter maximum number in array: ");
while (!int.TryParse(Console.ReadLine(), out max) || max < 0) //введенную строку записать в переменную до тех пор пока не успешно строка преобразована в число, я буду повторять попытку ввода до тех пор пока это не будет число и не будет положительным. проверка на буквы и отрицательные, если будет так,то будет повторять ввести верное число
{
    Console.WriteLine("Wrong number, try again");
}
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    if (i == 0) //цикл проверки на последнюю цифру,чтобы не было в конце запятой
        Console.Write($"[{array[i]}, ");
    else if (i == array.Length - 1)
        Console.Write($"{array[i]}]");
    else
        Console.Write($"{array[i]}, ");
}
Console.WriteLine(); */



/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
/* Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
В оригинале нужно пользователю ввести строку - ряд чисел через запятую, а программа превращает эту строку в полноценный массив и выводит. 
Рекомендую вторым вариантом) */

string output = "3, 56, 78, 4, 5"; // пройтись циклом и ориентируясь на запятые выделить подстроки. подстрока с числом и с пробелом. 
//int[] numbers = new int[];не знаем размер массива    //дальше преобразовать с помощью конверта в целые числа и засунуть в массив
int countNumbers = 1; //с 1 потому что запятых 4, а цифр 5.
for (int i = 0; i < output.Length; i++) //выяснить размер массива
{
    if (output[i] == ',')
        countNumbers++; //получим кол-во чисел
}

int[] numbers = new int[countNumbers]; //создаем массив равный кол-ву запятых

int numberIndex = 0;
for (int i = 0; i < output.Length; i++)
{
    string subString = String.Empty; // переменную подстроку и дадим пустую строку

    while (output[i] != ',') //записываем в строку символом столько пока не дойдет до запятой
    {
        if (i >= output.Length - 1)
            break; //нужно выйти из цикла когда закончится массив

        subString += output[i].ToString();
        i++;
    }

    if (subString == "" || subString == " ")
        continue; //если подстрока пустая и есть пробел

    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " "); //выводим массив
}
