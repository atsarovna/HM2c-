/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с
сторонами такой длины.
*Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

/* int InputNumbers(string name)
{
    Console.Write($"Enter three numbers of triangle {name}:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = InputNumbers("a");
int b = InputNumbers("b");
int c = InputNumbers("c");

if(a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine("This is triangle.");
}
else
{
    Console.WriteLine("This is not triangle.");
} */

// через массив

int[] array = new int[3]; //массив из 3 чисел

for (int i = 0; i < array.Length; i++)
{
    array[i] = GetValue();
}

if (array[0]<array[1]+array[2] && array[1]<array[0]+array[2] && array[2]<array[1]+array[0])
{
    Console.WriteLine("This is triangle.");
}
else
{
    Console.WriteLine("This is not triangle.");
}

int GetValue() //функция
{
    Console.Write("Enter a size of a side of a triangle: ");
    return Convert.ToInt32(Console.ReadLine());
}