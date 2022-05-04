/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */ // Факторил - 4 = 1*2*3*4 = 24

int number;
Console.Write("Please enter positive integer number: ");

while(!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Wrong number, try again");
}

/* Console.Write("Enter positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine()); */
int fact = 1;
for (int i=1; i<=number; i++)
{
    fact = fact * i;
}
Console.WriteLine($"Factorial of the number is: {fact}");

