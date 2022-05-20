// перемешать цифры в массиве. пример рандомное распределение людей по группам
// 1 алгоритм - перемешиваем рандомный индекс между собой
// 2 алгоритм - создаем доп.массив со случайными числами и вовремя сортировки случайных чисел,сортируется первый массив, который тоже случайно распределяется

//это 1 алгоритм, самый простой
int[] numbers = { 1, 2, 3, 4, 5, 6};

for(int i = 0; i < numbers.Length; i++)
{
    int randomIndex = new Random().Next(0, numbers.Length);
    int temp = numbers[i];
    numbers[i] = numbers[randomIndex];
    numbers[randomIndex] = temp;
}

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}