/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

//1 решение через строку
//int InputNumber(string chislo)
//{
    Console.Write($"Enter the number :");
    int number = Convert.ToInt32(Console.ReadLine());
    //return number;
//}

//int a = InputNumber("A");
int a = number;
string result = "" + a % 2;

while (a >= 2)
{
    a = a / 2;
    int c = a % 2;
    result = c + result;
}
Console.Write($"Your number in binary system is = {result}");

//2.через цикл for переворачиваем

/* Console.Write($"Enter the number :");
int number = Convert.ToInt32(Console.ReadLine());

string TempResult = string.Empty;
string result = string.Empty;

while (number != 0)
{
    TempResult += number % 2;
    number = number / 2;
}

for (int i = 0; i < TempResult.Length; i++)
{
    result += TempResult[TempResult.Length - 1 - i];
}

Console.Write($"Your number in binary system is = {result}"); */

//3.только через массив,без строки
/* int number = 8; //new Random().Next(0, int.MaxValue); //задаем рандомное число или можно любое ввести,например 8

int binSize = 0;

int TempNumber = number; 
while (TempNumber != 0) //считаем размер конечного числа для создания массива
{
    TempNumber /= 2; //чтобы задать массив нужно выяснить его размер, поэтому мы каждый раз делим число на 2 и + 1
    binSize++;
}

int[] binArray = new int[binSize]; //создаем этот массив с конца
TempNumber = number;
for (int i = binArray.Length - 1; i >= 0; i--) // перемножаем и записываем в обратном порядке
{
    binArray[i] = TempNumber % 2;
    TempNumber /= 2;
}

Console.WriteLine($"number = {number}");
PrintArray(binArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
} */