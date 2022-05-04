/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

//возвести в степень через цикл умножать на себя

int A;
Console.Write("Enter first number A: ");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0)
{
    Console.WriteLine("Wrong number, try again");
}

int B;
Console.Write("Enter second number B: ");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0)
{
    Console.WriteLine("Wrong number, try again");
}

int grade = 1;
for(int i = 1;i <= B; i++)
{
    grade*=A;
}
Console.WriteLine($"Number A in the grade B is: {grade}");
