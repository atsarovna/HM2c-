/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */ // Факторил - 4 = 1*2*3*4 = 24

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int fact = 1;
for (int i=1; i<=number; i++)
{
    fact = fact * i;
}
Console.WriteLine($"Factorial of the number is: {fact}");